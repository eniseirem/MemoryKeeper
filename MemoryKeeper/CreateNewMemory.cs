using MemoryKeeper.DaraBaseTablesClassses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryKeeper
{
    public partial class frmCreateNewMemory : Form
    {
        private Context _db;
        private string fileName { get; set; }
        private bool _isSearchedVal { get; set; }

        public frmCreateNewMemory()
        {


            _db = new Context();
            InitializeComponent();

            dtpMemoryDate.Enabled = false;
        }

        private void FrmCreateNewMemory_FormClosing(object sender, FormClosingEventArgs e)
        {
            var frm = new frmMainPage();
            frm.Show();
        }

        public frmCreateNewMemory(bool isSearchedVal, DaraBaseTablesClassses.Memory item)
        {
            _db = new Context();
            InitializeComponent();
            _isSearchedVal = isSearchedVal;
            if (_isSearchedVal)
            {
                rTxtDescription.ReadOnly = true;
                dtpMemoryDate.Enabled = false;
                btnSave.Enabled = false;
                nudRate.Enabled = false;
                button1.Enabled = false;
                label1.Text = "You can just read that";

                rTxtDescription.Text = item.Description;
                dtpMemoryDate.Value = item.CreatedDate;
                nudRate.Value = item.Rate;
                pbMemory.ImageLocation = Path.GetDirectoryName(Application.ExecutablePath) + @"\files\img\" + item.ImagePath;
                label1.Text = "You can just read that";


            }
        }

        #region Events
        private void frmCreateNewMemory_Load(object sender, EventArgs e)
        {
            this.FormClosing += FrmCreateNewMemory_FormClosing;
            nudRate.Maximum = 5;
            nudRate.Minimum = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (!_db.Memories.Where(x => x.CreatedDate.Equals(date)).Any())
            {
                if (CheckItems())
                {
                    OpenFileDialog opFile = new OpenFileDialog();
                    opFile.Title = "Select a Image";
                    opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

                    var newFileName = "default.png";

                    if (!string.IsNullOrEmpty(pbMemory.ImageLocation))
                    {
                        var filePath = pbMemory.ImageLocation.ToString();
                        var fileName = Path.GetFileName(filePath);
                        newFileName = Guid.NewGuid().ToString() + Path.GetExtension(filePath);
                        File.Copy(filePath, Path.GetDirectoryName(Application.ExecutablePath) + @"\files\img\" + newFileName);
                    }

                    _db.Memories.Add(new DaraBaseTablesClassses.Memory
                    {
                        Id = Guid.NewGuid().ToString(),
                        Description = rTxtDescription.Text,
                        ImagePath = newFileName,
                        Rate = Convert.ToInt32(nudRate.Value),
                        UserId = _db.Users.FirstOrDefault().Id,
                        CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                    });
                    if (_db.SaveChanges() > 0)
                    {
                        MessageBox.Show("This process was Successful", "Success");
                        this.Close();
                        var frm = new frmMainPage();
                        frm.Show();
                    }
                    else
                        MessageBox.Show("This process was failed", "Failed");
                }
            }
            else
            {
                MessageBox.Show("You cant save a Journal at same date", "Failed");
            }
        }
        #endregion

        #region Helpers
        public bool CheckItems()
        {
            bool isOk = true;
            if (string.IsNullOrEmpty(rTxtDescription.Text))
            {
                isOk = false;
                MessageBox.Show("This Description is required!", "Error");
            }
            return isOk;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;|"
   + "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png";
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbMemory.ImageLocation = fileDialog.FileName;
            }
        }

    }
}
