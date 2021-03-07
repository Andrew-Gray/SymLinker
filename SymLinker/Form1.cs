using System;
using System.IO;
using System.Windows.Forms;

namespace SymLinker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SrcSearch_Click(object sender, EventArgs e)
        {
            srcText.Text = DialogResults();
        }

        private void DestSearch_Click(object sender, EventArgs e)
        {
            destText.Text = DialogResults();
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {

            // Folders
            string source = srcText.Text;
            string destination = destText.Text;
            bool doesSourceExist = Directory.Exists(source);

            // Symbolic link vars
            const string symLinkBase = "mklink /D ";

            // Copy vars
            bool shouldICopy = false;
            const string copyBase = "Robocopy /MOVE /S /E ";


            if (!string.IsNullOrEmpty(source) && 
                !string.IsNullOrEmpty(destination) && 
                source.ToLower() != destination.ToLower())
            {
                // Create symbolic link and copy cmd commands.
                string symLinkCmd = symLinkBase + "\"" + source + "\" \"" + destination + "\"";
                string copyCmd = copyBase + "\"" + source + "\" \"" + destination + "\"";

                // When copy radio selected, set shouldICopy to true. 
                // False value means we should not copy and just delete the content
                if (copyDeleteRadio.Checked) shouldICopy = true;

                if (doesSourceExist && shouldICopy)
                {
                    // Copy
                    RunCmd(copyCmd + " & " + symLinkCmd);
                    SymLinkCompleteMsg();
                }
                else if (doesSourceExist && !shouldICopy)
                {
                    // Delete
                    DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (res == DialogResult.OK)
                    {
                        // OK selected
                        Directory.Delete(source);
                        RunCmd(symLinkCmd);
                        SymLinkCompleteMsg();
                    }
                    else
                    {
                        // Cancel selected
                        MessageBox.Show("Operation has been Canceled");
                    }
                }
                else
                {
                    // Source location doesn't exist so we can just create the Symbolic link
                    RunCmd(symLinkCmd);
                    SymLinkCompleteMsg();
                }

            }
            else if (source.ToLower() == destination.ToLower())
            {
                ShowError("Source and Destination cannot match");
            }
            else if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(destination))
            {
                ShowError("Please make sure the Source and Destination fields have been filled in");
            }

        }

        private string DialogResults()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                string resultText = "";
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    resultText = fbd.SelectedPath;
                }

                return resultText;
            }
        }

        private void RunCmd(string command) {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/user:Administrator \"cmd /K " + command
            };
            process.StartInfo = startInfo;
            process.Start();
        }

        private void ShowError(string msg) {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SymLinkCompleteMsg()
        {
            MessageBox.Show("The symbolic link has been created", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
