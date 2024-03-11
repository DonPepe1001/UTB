namespace UTB
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PctLogoLogin = new System.Windows.Forms.PictureBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BttLogin = new System.Windows.Forms.Button();
            this.LblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PctLogoLogin
            // 
            this.PctLogoLogin.Image = ((System.Drawing.Image)(resources.GetObject("PctLogoLogin.Image")));
            this.PctLogoLogin.Location = new System.Drawing.Point(199, 129);
            this.PctLogoLogin.Name = "PctLogoLogin";
            this.PctLogoLogin.Size = new System.Drawing.Size(350, 350);
            this.PctLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLogoLogin.TabIndex = 0;
            this.PctLogoLogin.TabStop = false;
            // 
            // TxtUser
            // 
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtUser.Location = new System.Drawing.Point(199, 530);
            this.TxtUser.MaxLength = 25;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(350, 29);
            this.TxtUser.TabIndex = 1;
            this.TxtUser.Text = "username";
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtUser_MouseClick);
            this.TxtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUser_KeyPress);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtPassword.Location = new System.Drawing.Point(199, 565);
            this.TxtPassword.MaxLength = 25;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(350, 29);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.Text = "password";
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtPassword_MouseClick);
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // BttLogin
            // 
            this.BttLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BttLogin.BackColor = System.Drawing.Color.White;
            this.BttLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttLogin.Location = new System.Drawing.Point(335, 709);
            this.BttLogin.Name = "BttLogin";
            this.BttLogin.Size = new System.Drawing.Size(75, 35);
            this.BttLogin.TabIndex = 3;
            this.BttLogin.Text = "Login";
            this.BttLogin.UseVisualStyleBackColor = false;
            this.BttLogin.Click += new System.EventHandler(this.BttLogin_Click);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.BackColor = System.Drawing.Color.Red;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.Location = new System.Drawing.Point(172, 654);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(405, 33);
            this.LblError.TabIndex = 4;
            this.LblError.Text = "Wrong password or username";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(762, 1100);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.BttLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.PctLogoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.PctLogoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctLogoLogin;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BttLogin;
        private System.Windows.Forms.Label LblError;
    }
}