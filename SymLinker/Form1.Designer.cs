
namespace SymLinker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.srcText = new System.Windows.Forms.TextBox();
            this.destText = new System.Windows.Forms.TextBox();
            this.sourceLbl = new System.Windows.Forms.Label();
            this.destLbl = new System.Windows.Forms.Label();
            this.srcSearch = new System.Windows.Forms.Button();
            this.destSearch = new System.Windows.Forms.Button();
            this.srcExists = new System.Windows.Forms.GroupBox();
            this.copyDeleteRadio = new System.Windows.Forms.RadioButton();
            this.deleteRadio = new System.Windows.Forms.RadioButton();
            this.runBtn = new System.Windows.Forms.Button();
            this.srcExists.SuspendLayout();
            this.SuspendLayout();
            // 
            // srcText
            // 
            this.srcText.Location = new System.Drawing.Point(110, 15);
            this.srcText.Name = "srcText";
            this.srcText.Size = new System.Drawing.Size(503, 27);
            this.srcText.TabIndex = 0;
            // 
            // destText
            // 
            this.destText.Location = new System.Drawing.Point(110, 50);
            this.destText.Name = "destText";
            this.destText.Size = new System.Drawing.Size(503, 27);
            this.destText.TabIndex = 1;
            // 
            // sourceLbl
            // 
            this.sourceLbl.AutoSize = true;
            this.sourceLbl.Location = new System.Drawing.Point(12, 18);
            this.sourceLbl.Name = "sourceLbl";
            this.sourceLbl.Size = new System.Drawing.Size(60, 20);
            this.sourceLbl.TabIndex = 2;
            this.sourceLbl.Text = "Source:";
            // 
            // destLbl
            // 
            this.destLbl.AutoSize = true;
            this.destLbl.Location = new System.Drawing.Point(12, 53);
            this.destLbl.Name = "destLbl";
            this.destLbl.Size = new System.Drawing.Size(92, 20);
            this.destLbl.TabIndex = 3;
            this.destLbl.Text = "Destination:";
            // 
            // srcSearch
            // 
            this.srcSearch.Location = new System.Drawing.Point(619, 15);
            this.srcSearch.Name = "srcSearch";
            this.srcSearch.Size = new System.Drawing.Size(92, 27);
            this.srcSearch.TabIndex = 5;
            this.srcSearch.Text = "Search";
            this.srcSearch.UseVisualStyleBackColor = true;
            this.srcSearch.Click += new System.EventHandler(this.SrcSearch_Click);
            // 
            // destSearch
            // 
            this.destSearch.Location = new System.Drawing.Point(619, 50);
            this.destSearch.Name = "destSearch";
            this.destSearch.Size = new System.Drawing.Size(92, 27);
            this.destSearch.TabIndex = 6;
            this.destSearch.Text = "Search";
            this.destSearch.UseVisualStyleBackColor = true;
            this.destSearch.Click += new System.EventHandler(this.DestSearch_Click);
            // 
            // srcExists
            // 
            this.srcExists.Controls.Add(this.copyDeleteRadio);
            this.srcExists.Controls.Add(this.deleteRadio);
            this.srcExists.Location = new System.Drawing.Point(16, 92);
            this.srcExists.Name = "srcExists";
            this.srcExists.Size = new System.Drawing.Size(597, 89);
            this.srcExists.TabIndex = 7;
            this.srcExists.TabStop = false;
            this.srcExists.Text = "If the source location exists";
            // 
            // copyDeleteRadio
            // 
            this.copyDeleteRadio.AutoSize = true;
            this.copyDeleteRadio.Checked = true;
            this.copyDeleteRadio.Location = new System.Drawing.Point(7, 56);
            this.copyDeleteRadio.Name = "copyDeleteRadio";
            this.copyDeleteRadio.Size = new System.Drawing.Size(318, 24);
            this.copyDeleteRadio.TabIndex = 1;
            this.copyDeleteRadio.TabStop = true;
            this.copyDeleteRadio.Text = "Copy contents to destination then delete it";
            this.copyDeleteRadio.UseVisualStyleBackColor = true;
            // 
            // deleteRadio
            // 
            this.deleteRadio.AutoSize = true;
            this.deleteRadio.Location = new System.Drawing.Point(7, 26);
            this.deleteRadio.Name = "deleteRadio";
            this.deleteRadio.Size = new System.Drawing.Size(84, 24);
            this.deleteRadio.TabIndex = 0;
            this.deleteRadio.Text = "Delete it";
            this.deleteRadio.UseVisualStyleBackColor = true;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(619, 155);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(92, 26);
            this.runBtn.TabIndex = 8;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(719, 192);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.srcExists);
            this.Controls.Add(this.destSearch);
            this.Controls.Add(this.srcSearch);
            this.Controls.Add(this.destLbl);
            this.Controls.Add(this.sourceLbl);
            this.Controls.Add(this.destText);
            this.Controls.Add(this.srcText);
            this.Font = new System.Drawing.Font("Open Sans", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SymLinker";
            this.srcExists.ResumeLayout(false);
            this.srcExists.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox srcText;
        private System.Windows.Forms.TextBox destText;
        private System.Windows.Forms.Label sourceLbl;
        private System.Windows.Forms.Label destLbl;
        private System.Windows.Forms.Button srcSearch;
        private System.Windows.Forms.Button destSearch;
        private System.Windows.Forms.GroupBox srcExists;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.RadioButton copyDeleteRadio;
        private System.Windows.Forms.RadioButton deleteRadio;
    }
}

