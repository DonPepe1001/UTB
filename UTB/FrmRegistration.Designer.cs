namespace UTB
{
    partial class FrmRegistration
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
            this.LblRegister = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.PnlRegistration = new System.Windows.Forms.Panel();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.PnlRight = new System.Windows.Forms.Panel();
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.BttReturn = new System.Windows.Forms.Button();
            this.BttRegister = new System.Windows.Forms.Button();
            this.LblError = new System.Windows.Forms.Label();
            this.LblNoInfo = new System.Windows.Forms.Label();
            this.PnlRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblRegister
            // 
            this.LblRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegister.ForeColor = System.Drawing.Color.White;
            this.LblRegister.Location = new System.Drawing.Point(0, 0);
            this.LblRegister.Name = "LblRegister";
            this.LblRegister.Size = new System.Drawing.Size(746, 175);
            this.LblRegister.TabIndex = 0;
            this.LblRegister.Text = "Register";
            this.LblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.Color.White;
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.Color.Gray;
            this.TxtUsername.Location = new System.Drawing.Point(249, 86);
            this.TxtUsername.MaxLength = 23;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(250, 29);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.Text = "username";
            this.TxtUsername.Click += new System.EventHandler(this.TxtUsername_Click);
            this.TxtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.White;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Gray;
            this.TxtPassword.Location = new System.Drawing.Point(249, 186);
            this.TxtPassword.MaxLength = 21;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(250, 29);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.Text = "password";
            this.TxtPassword.Click += new System.EventHandler(this.TxtPassword_Click);
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.TxtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.TxtConfirmPassword.Location = new System.Drawing.Point(249, 236);
            this.TxtConfirmPassword.MaxLength = 21;
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(250, 29);
            this.TxtConfirmPassword.TabIndex = 3;
            this.TxtConfirmPassword.Text = "confirm password";
            this.TxtConfirmPassword.Click += new System.EventHandler(this.TxtConfirmPassword_Click);
            this.TxtConfirmPassword.TextChanged += new System.EventHandler(this.TxtConfirmPassword_TextChanged);
            // 
            // PnlRegistration
            // 
            this.PnlRegistration.BackColor = System.Drawing.Color.White;
            this.PnlRegistration.Controls.Add(this.LblNoInfo);
            this.PnlRegistration.Controls.Add(this.LblError);
            this.PnlRegistration.Controls.Add(this.BttRegister);
            this.PnlRegistration.Controls.Add(this.BttReturn);
            this.PnlRegistration.Controls.Add(this.TxtEmail);
            this.PnlRegistration.Controls.Add(this.TxtPassword);
            this.PnlRegistration.Controls.Add(this.TxtUsername);
            this.PnlRegistration.Controls.Add(this.TxtConfirmPassword);
            this.PnlRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlRegistration.Location = new System.Drawing.Point(0, 175);
            this.PnlRegistration.Name = "PnlRegistration";
            this.PnlRegistration.Size = new System.Drawing.Size(746, 886);
            this.PnlRegistration.TabIndex = 6;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.White;
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.Gray;
            this.TxtEmail.Location = new System.Drawing.Point(249, 136);
            this.TxtEmail.MaxLength = 23;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(250, 29);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.Text = "e-mail";
            this.TxtEmail.Click += new System.EventHandler(this.TxtEmail_Click);
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // PnlRight
            // 
            this.PnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlRight.Location = new System.Drawing.Point(546, 175);
            this.PnlRight.Name = "PnlRight";
            this.PnlRight.Size = new System.Drawing.Size(200, 886);
            this.PnlRight.TabIndex = 7;
            // 
            // PnlLeft
            // 
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 175);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(200, 886);
            this.PnlLeft.TabIndex = 8;
            // 
            // PnlBottom
            // 
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(200, 886);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(346, 175);
            this.PnlBottom.TabIndex = 9;
            // 
            // BttReturn
            // 
            this.BttReturn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BttReturn.ForeColor = System.Drawing.Color.White;
            this.BttReturn.Location = new System.Drawing.Point(207, 669);
            this.BttReturn.Name = "BttReturn";
            this.BttReturn.Size = new System.Drawing.Size(75, 36);
            this.BttReturn.TabIndex = 6;
            this.BttReturn.Text = "Back";
            this.BttReturn.UseVisualStyleBackColor = false;
            this.BttReturn.Click += new System.EventHandler(this.BttReturn_Click);
            // 
            // BttRegister
            // 
            this.BttRegister.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BttRegister.ForeColor = System.Drawing.Color.White;
            this.BttRegister.Location = new System.Drawing.Point(465, 669);
            this.BttRegister.Name = "BttRegister";
            this.BttRegister.Size = new System.Drawing.Size(75, 36);
            this.BttRegister.TabIndex = 7;
            this.BttRegister.Text = "Register";
            this.BttRegister.UseVisualStyleBackColor = false;
            this.BttRegister.Click += new System.EventHandler(this.BttRegister_Click);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.BackColor = System.Drawing.Color.Red;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Black;
            this.LblError.Location = new System.Drawing.Point(206, 406);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(334, 33);
            this.LblError.TabIndex = 8;
            this.LblError.Text = "Passwords do not match";
            // 
            // LblNoInfo
            // 
            this.LblNoInfo.AutoSize = true;
            this.LblNoInfo.BackColor = System.Drawing.Color.Red;
            this.LblNoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoInfo.ForeColor = System.Drawing.Color.Black;
            this.LblNoInfo.Location = new System.Drawing.Point(206, 406);
            this.LblNoInfo.Name = "LblNoInfo";
            this.LblNoInfo.Size = new System.Drawing.Size(312, 33);
            this.LblNoInfo.TabIndex = 9;
            this.LblNoInfo.Text = "Incomplete Information";
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(746, 1061);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.PnlLeft);
            this.Controls.Add(this.PnlRight);
            this.Controls.Add(this.PnlRegistration);
            this.Controls.Add(this.LblRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistration";
            this.PnlRegistration.ResumeLayout(false);
            this.PnlRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblRegister;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.Panel PnlRegistration;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Panel PnlRight;
        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Button BttRegister;
        private System.Windows.Forms.Button BttReturn;
        private System.Windows.Forms.Label LblNoInfo;
    }
}