using System;
using System.Windows.Forms;
using Unity;

namespace TextEditor
{
    public partial class MainForm : Form
    {
        private IUnityContainer _unityContainer;
        bool isSaved;
        string currentName;
        public delegate void RichTextBoxChanged(string data);
        public delegate void CurrentFileNameChanged(string data);


        public MainForm(IUnityContainer unityContainer)
        {
            InitializeComponent();
            _unityContainer = unityContainer;
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSaved == false)
            {
                if (MessageBox.Show("Changes were not saved. Exit?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                };
            }
        }

        private void funcRichTextBoxChanged(string data)
        {
            richTextBox1.Text = data;
        }

        private void funcNameChanged(string data)
        {
            currentName = data;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isSaved = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uplBtn_Click(object sender, EventArgs e)
        {
            UploadFileForm _uploadFileForm = new UploadFileForm(_unityContainer);
            _uploadFileForm.Body = richTextBox1.Text;
            _uploadFileForm.FileName = currentName;
            _uploadFileForm.ShowDialog();

            isSaved = true;
        }

        private void dwnlBtn_Click(object sender, EventArgs e)
        {
            DownloadFileForm _downloadFileForm = new DownloadFileForm(_unityContainer,
                new RichTextBoxChanged(funcRichTextBoxChanged),
                new CurrentFileNameChanged(funcNameChanged));
            _downloadFileForm.ShowDialog();
        }
    }
}
