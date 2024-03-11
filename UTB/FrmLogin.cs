using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTB
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            LblError.Hide();
        }
        private async void BttLogin_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "12345" && TxtUser.Text != "username" && TxtUser.Text != string.Empty)
            {   
                FrmUTB frmUTB = new FrmUTB();
                frmUTB.Username = Username;
                this.Hide();
                frmUTB.Show();
            }
            else
            {
                LblError.Show();
                await Task.Delay(2000);
                LblError.Hide();
            }
        }
  
        private void TxtUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtPassword.Text == string.Empty)
            {
                TxtPassword.Text = "password";
                TxtPassword.UseSystemPasswordChar = false;
                TxtPassword.ForeColor = Color.Gray;
            }
            TxtUser.ForeColor = Color.Black;
            if (TxtUser.Text == "username")
            {
                TxtUser.Text = string.Empty;
            }
        }

        private void TxtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtUser.Text == string.Empty)
            {
                TxtUser.ForeColor = Color.Gray;
                TxtUser.Text = "username";
            }
            TxtPassword.UseSystemPasswordChar = true;
            TxtPassword.ForeColor = Color.Black;
            if (TxtPassword.Text == "password")
            {
                TxtPassword.Text = string.Empty;
            }
        }
        public string Username
        {
            get { return TxtUser.Text; }
        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtUser.ForeColor = Color.Black;
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            TxtPassword.ForeColor = Color.Black;
            TxtPassword.UseSystemPasswordChar = true;
        }

        private void LblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();
            this.Hide();
            frmRegistration.Show();
        }
    }
}
