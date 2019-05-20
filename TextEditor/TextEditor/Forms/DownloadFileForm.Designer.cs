namespace TextEditor
{
    partial class DownloadFileForm
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
            this.labelComment = new System.Windows.Forms.Label();
            this.btnDwnlFile = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listBoxFileName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(94, 19);
            this.labelComment.MaximumSize = new System.Drawing.Size(193, 17);
            this.labelComment.MinimumSize = new System.Drawing.Size(193, 17);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(193, 17);
            this.labelComment.TabIndex = 0;
            this.labelComment.Text = "Select file name to download";
            // 
            // btnDwnlFile
            // 
            this.btnDwnlFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDwnlFile.Location = new System.Drawing.Point(39, 422);
            this.btnDwnlFile.Name = "btnDwnlFile";
            this.btnDwnlFile.Size = new System.Drawing.Size(75, 30);
            this.btnDwnlFile.TabIndex = 1;
            this.btnDwnlFile.Text = "Open";
            this.btnDwnlFile.UseVisualStyleBackColor = true;
            this.btnDwnlFile.Click += new System.EventHandler(this.btnDwnlFile_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(250, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listBoxFileName
            // 
            this.listBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFileName.FormattingEnabled = true;
            this.listBoxFileName.ItemHeight = 16;
            this.listBoxFileName.Location = new System.Drawing.Point(39, 52);
            this.listBoxFileName.Name = "listBoxFileName";
            this.listBoxFileName.Size = new System.Drawing.Size(286, 340);
            this.listBoxFileName.TabIndex = 3;
            // 
            // DownloadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 464);
            this.Controls.Add(this.listBoxFileName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDwnlFile);
            this.Controls.Add(this.labelComment);
            this.MinimumSize = new System.Drawing.Size(392, 511);
            this.Name = "DownloadFileForm";
            this.Text = "DownloadFile";
            this.Load += new System.EventHandler(this.DownloadFileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Button btnDwnlFile;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listBoxFileName;
    }
}