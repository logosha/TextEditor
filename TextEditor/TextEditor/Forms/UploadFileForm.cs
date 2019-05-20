using Core.DBService;
using Shared;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Unity;
using File = Shared.File;

namespace TextEditor
{
    public partial class UploadFileForm : Form
    {
        private IUnityContainer _unityContainer;

        public UploadFileForm(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
            InitializeComponent();
        }

        public string Body { get; set; }
        public string FileName { get; set; }

        private async void btnUplFile_Click(object sender, EventArgs e)
        {
            if (!textBoxFileName.Text.Contains("."))
            {
                MessageBox.Show("Please add filename extension!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    using (var dbService = _unityContainer.Resolve<IDbService>())
                    {
                        IRepo<File> repo = dbService.Repo<File>();

                        if (FileName.Length > 0)
                        {
                            var item = await repo.GetByName(t => t.FileName == FileName);
                            item.FileBody = Encoding.UTF8.GetBytes(Body);
                            await repo.Update(item);
                        }
                        else
                        {
                            await repo.Add(new File() { FileName = FileName, FileBody = Encoding.UTF8.GetBytes(Body) });
                        }

                        await dbService.SaveChangesAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                Close();
            }
        }

        private void UploadFileForm_Load(object sender, EventArgs e)
        {
            textBoxFileName.Text = FileName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
