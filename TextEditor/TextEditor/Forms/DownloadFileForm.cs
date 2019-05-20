using Core.DBService;
using Shared;
using System;
using System.Text;
using System.Windows.Forms;
using Unity;
using static TextEditor.MainForm;

namespace TextEditor
{
    public partial class DownloadFileForm : Form
    {
        private IUnityContainer _unityContainer;
        private RichTextBoxChanged changeRichTextBox;
        private CurrentFileNameChanged changeCurrentFileName;

        public DownloadFileForm(IUnityContainer unityContainer, RichTextBoxChanged sender, CurrentFileNameChanged changer)
        {
            _unityContainer = unityContainer;
            InitializeComponent();
            changeRichTextBox = sender;
            changeCurrentFileName = changer;
        }

        public string Body { get; set; }

        private async void DownloadFileForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var dbService = _unityContainer.Resolve<IDbService>())
                {
                    IRepo<File> repo = dbService.Repo<File>();
                    var files = await repo.GetAll();

                    foreach (var item in files)
                    {
                        listBoxFileName.Items.Add(item.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnDwnlFile_Click(object sender, EventArgs e)
        {
            var fileName = listBoxFileName.SelectedItem.ToString();

            try
            {
                using (var dbService = _unityContainer.Resolve<IDbService>())
                {
                    IRepo<File> repo = dbService.Repo<File>();
                    var file = await repo.GetByName(s => s.FileName.Equals(fileName));
                    var body = Encoding.UTF8.GetString(file.FileBody);
                    changeRichTextBox(body);
                    changeCurrentFileName(fileName);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
