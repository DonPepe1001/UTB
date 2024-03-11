using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UTB
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            LblError.Hide();
            LblNoInfo.Hide();
            LblMail.Hide();
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            TxtUsername.ForeColor = Color.Black;
        }
        private async void BttRegister_Click(object sender, EventArgs e)
        {
            bool passwordMatch = false;
            if (TxtPassword.Text != TxtConfirmPassword.Text)
            {
                LblError.Show();
                await Task.Delay(2000);
                LblError.Hide();
                passwordMatch = false;
            }
            if (TxtEmail.Text == "e-mail" || TxtUsername.Text == "username" || TxtEmail.Text == string.Empty || TxtUsername.Text == string.Empty)
            {
                LblNoInfo.Show();
                await Task.Delay(2000);
                LblNoInfo.Hide();
            }
            if (!this.TxtEmail.Text.Contains('@') || !this.TxtEmail.Text.Contains('.'))
            {
                LblMail.Show();
                await Task.Delay(2000);
                LblMail.Hide();
            }
            if (TxtPassword.Text == TxtConfirmPassword.Text)
            {
                passwordMatch = true;
            }
            if (passwordMatch == true && TxtUsername.Text != "username" && TxtUsername.Text != string.Empty && TxtEmail.Text != "e-mail" && TxtEmail.Text != string.Empty && this.TxtEmail.Text.Contains('@') && this.TxtEmail.Text.Contains('.'))
            {
                FrmUTB frmUTB = new FrmUTB();
                frmUTB.Username = Username;
                this.Hide();
                frmUTB.Show();
            }
        }

        private void TxtUsername_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "username")
            {
                TxtUsername.Text = string.Empty;
            }
            if (TxtEmail.Text == string.Empty)
            {
                TxtEmail.Text = "e-mail";
                TxtEmail.ForeColor = Color.Gray;
            }
            if (TxtPassword.Text == string.Empty)
            {
                TxtPassword.Text = "password";
                TxtPassword.UseSystemPasswordChar = false;
                TxtPassword.ForeColor = Color.Gray;
            }
            if (TxtConfirmPassword.Text == string.Empty)
            {
                TxtConfirmPassword.Text = "confirm password";
                TxtConfirmPassword.UseSystemPasswordChar = false;
                TxtConfirmPassword.ForeColor = Color.Gray;
            }
        }

        private void BttReturn_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            TxtEmail.ForeColor= Color.Black;
        }

        private void TxtEmail_Click(object sender, EventArgs e)
        {
            if (TxtEmail.Text == "e-mail")
            { 
                TxtEmail.Text = string.Empty;
            }
            if (TxtUsername.Text == string.Empty)
            {
                TxtUsername.Text = "username";
                TxtUsername.ForeColor = Color.Gray;
            }
            if (TxtPassword.Text == string.Empty)
            {
                TxtPassword.Text = "password";
                TxtPassword.UseSystemPasswordChar = false;
                TxtPassword.ForeColor = Color.Gray;
            }
            if (TxtConfirmPassword.Text == string.Empty)
            {
                TxtConfirmPassword.Text = "confirm password";
                TxtConfirmPassword.UseSystemPasswordChar = false;
                TxtConfirmPassword.ForeColor = Color.Gray;
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            TxtPassword.ForeColor = Color.Black;
            TxtPassword.UseSystemPasswordChar = true;
        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "password")
            {
                TxtPassword.Text = string.Empty;
                TxtPassword.UseSystemPasswordChar = true;
            }
            if (TxtUsername.Text == string.Empty)
            {
                TxtUsername.Text = "username";
                TxtUsername.ForeColor = Color.Gray;
            }
            if (TxtEmail.Text == string.Empty)
            {
                TxtEmail.Text = "e-mail";
                TxtEmail.ForeColor = Color.Gray;
            }
            if (TxtConfirmPassword.Text == string.Empty)
            {
                TxtConfirmPassword.Text = "confirm password";
                TxtConfirmPassword.UseSystemPasswordChar = false;
                TxtConfirmPassword.ForeColor = Color.Gray;
            }
        }

        private void TxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            TxtConfirmPassword.ForeColor = Color.Black;
            TxtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void TxtConfirmPassword_Click(object sender, EventArgs e)
        {
            if (TxtConfirmPassword.Text == "confirm password")
            {
                TxtConfirmPassword.Text = string.Empty;
                TxtConfirmPassword.UseSystemPasswordChar = true;
            }
            if (TxtUsername.Text == string.Empty)
            {
                TxtUsername.Text = "username";
                TxtUsername.ForeColor = Color.Gray;
            }
            if (TxtEmail.Text == string.Empty)
            {
                TxtEmail.Text = "e-mail";
                TxtEmail.ForeColor = Color.Gray;
            }
            if (TxtPassword.Text == string.Empty)
            {
                TxtPassword.Text = "password";
                TxtPassword.UseSystemPasswordChar = false;
                TxtPassword.ForeColor = Color.Gray;
            }
        }
        public string Username
        {
            get { return TxtUsername.Text; }
        }
    }
}
