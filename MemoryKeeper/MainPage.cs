using MemoryKeeper.DaraBaseTablesClassses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryKeeper
{
    public partial class frmMainPage : Form
    {
        private Context _db { get; set; }
        public frmMainPage()
        {
            _db = new Context();
            InitializeComponent();

        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            this.FormClosed += FrmMainPage_FormClosed;
            this.txtHastag.GotFocus += TxtHastag_GotFocus;
        }

        private void TxtHastag_GotFocus(object sender, EventArgs e)
        {
            txtHastag.Text = "";
        }

        private void FrmMainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            var frm = new frmLoginPage();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmCreateNewMemory();
            this.Hide();
            frm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //search with date
            var date = Convert.ToDateTime(dtSearchDate.Value.ToShortDateString());
            var result = _db.Memories.Where(x => x.CreatedDate.Equals(date)).FirstOrDefault();
            if (result != null)
            {
                var frm = new frmCreateNewMemory(true, result);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not found", "Error");
            }
        }

        private void btnSearchForHastag_Click(object sender, EventArgs e)
        {
            if (txtHastag.Text.Contains('#'))
            {
                var result = _db.Memories.Where(x => x.Description.Contains(txtHastag.Text)).ToList();
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        lstHastagList.Items.Add(item);
                    }
                    lstHastagList.DisplayMember = "CreatedDate";
                    lstHastagList.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show("Not found", "Error");
                }
            }
            else
            {
                MessageBox.Show("The Hastag format is not valid! You have to add to '#' first letter", "Error");
            }
        }

        private void lstHastagList_DoubleClick(object sender, EventArgs e)
        {
            var result = lstHastagList.SelectedItem as DaraBaseTablesClassses.Memory;
            var frm = new frmCreateNewMemory(true, result);
            frm.Show();
            this.Hide();
        }
    }
}
