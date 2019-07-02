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
    public partial class frmLoginPage : Form
    {
        private Context _db;
        public frmLoginPage()
        {
            _db = new Context();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_db.Users.FirstOrDefault() != null)
                btnNewUser.Enabled = false;

            this.FormClosed += FrmLoginPage_FormClosed;
        }

        private void FrmLoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region Events
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (CheckItems())
            {
                _db.Users.Add(new User
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = txtEmail.Text,
                    Password = TxtPassword.Text,
                    CreatedDate = DateTime.Now
                });

                if (_db.SaveChanges() > 0)
                {
                    MessageBox.Show("Successful!", "This Record created as Successful");
                    var frm = new frmMainPage();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed!", "This record cant create!");
                }
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckItems())
            {
                var currentUser = _db.Users.Where(x =>
                         x.Email.ToLower() == txtEmail.Text.ToLower()
                        ).FirstOrDefault();
                if (currentUser != null)
                {
                    if (currentUser.Password.ToLower().Equals(TxtPassword.Text.ToLower()))
                    {
                        var frm = new frmMainPage();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        errorProvider1.SetError(TxtPassword, "Password is incorrec");
                        MessageBox.Show("Password is incorrect!", "Error");
                    }
                }
                else
                    MessageBox.Show("This user is not include in Database", "Error");
            }
            else
            {
                MessageBox.Show("Your Email or password is incorrect!", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmForgotPassword();
            frm.Show();
            this.Close();
        }
        #endregion

        #region Helpers

        public bool CheckItems()
        {
            System.Text.RegularExpressions.Regex checkEmailFormat = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            bool isOK = true;
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                isOK = false;
                errorProvider1.SetError(txtEmail, "This item is required!");
            }
            else if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                isOK = false;
                errorProvider1.SetError(TxtPassword, "This item is required!");
            }
            if (!checkEmailFormat.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "This Email format is not correct!");
                isOK = false;
            }
            else
                isOK = true;

            return isOK;
        }
        #endregion
    }
}
