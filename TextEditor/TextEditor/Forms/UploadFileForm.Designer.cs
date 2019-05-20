namespace TextEditor
{
    partial class UploadFileForm
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
            this.btnUplFile = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(113, 18);
            this.labelComment.MaximumSize = new System.Drawing.Size(153, 17);
            this.labelComment.MinimumSize = new System.Drawing.Size(153, 17);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(153, 17);
            this.labelComment.TabIndex = 0;
            this.labelComment.Text = "Enter file name to save";
            // 
            // btnUplFile
            // 
            this.btnUplFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUplFile.Location = new System.Drawing.Point(46, 87);
            this.btnUplFile.Name = "btnUplFile";
            this.btnUplFile.Size = new System.Drawing.Size(75, 30);
            this.btnUplFile.TabIndex = 1;
            this.btnUplFile.Text = "Upload";
            this.btnUplFile.UseVisualStyleBackColor = true;
            this.btnUplFile.Click += new System.EventHandler(this.btnUplFile_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(250, 87);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileName.Location = new System.Drawing.Point(27, 47);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(318, 22);
            this.textBoxFileName.TabIndex = 3;
            // 
            // UploadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 129);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUplFile);
            this.Controls.Add(this.labelComment);
            this.MinimumSize = new System.Drawing.Size(392, 176);
            this.Name = "UploadFileForm";
            this.Text = "UploadFile";
            this.Load += new System.EventHandler(this.UploadFileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Button btnUplFile;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxFileName;
    }
}