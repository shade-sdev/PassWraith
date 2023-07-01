using PassWraith.Data;
using PassWraith.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PassWraith.Forms
{
    public partial class Import : Form
    {

        private readonly IPassWraithContext _context;

        private string path;

        public Import(IPassWraithContext _context)
        {
            InitializeComponent();
            this._context = _context;
        }

        private void UploadPanel_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                string path = fileList[0];
                this.path = path;
                Notification.ShowNotification(ToolTipIcon.Info, 3000, "Imported", "Path has been imported");
            }
            catch
            {
            }
        }

        private async void ImportBtn_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                Notification.ShowNotification(ToolTipIcon.Info, 3000, "Importing", "CSV is being imported please wait");
                await CommaSeparatedHelper.ImportExcel(path, _context, checkBox.Checked);
                var passWraithForm = Application.OpenForms.OfType<PassWraith>().FirstOrDefault();
                await passWraithForm.mouseEvents.ClearFlpMain();
                await passWraithForm.mouseEvents.Load(passWraithForm.mouseEvents.filterType);
                Close();
            }
        }
    }
}