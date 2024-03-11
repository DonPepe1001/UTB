namespace UTB
{
    partial class FrmUTB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUTB));
            this.PnlTopBar = new System.Windows.Forms.Panel();
            this.BttClear = new System.Windows.Forms.Button();
            this.PctLogoChat = new System.Windows.Forms.PictureBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.BttClose = new System.Windows.Forms.Button();
            this.PnlMessage = new System.Windows.Forms.Panel();
            this.BttSendMessage = new System.Windows.Forms.Button();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.PnlConversation = new System.Windows.Forms.Panel();
            this.LstConversation = new System.Windows.Forms.ListBox();
            this.PnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogoChat)).BeginInit();
            this.PnlMessage.SuspendLayout();
            this.PnlConversation.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTopBar
            // 
            this.PnlTopBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.PnlTopBar.Controls.Add(this.BttClear);
            this.PnlTopBar.Controls.Add(this.PctLogoChat);
            this.PnlTopBar.Controls.Add(this.LblUsername);
            this.PnlTopBar.Controls.Add(this.BttClose);
            this.PnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTopBar.Name = "PnlTopBar";
            this.PnlTopBar.Size = new System.Drawing.Size(778, 120);
            this.PnlTopBar.TabIndex = 0;
            // 
            // BttClear
            // 
            this.BttClear.BackColor = System.Drawing.Color.White;
            this.BttClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BttClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttClear.ForeColor = System.Drawing.Color.Black;
            this.BttClear.Location = new System.Drawing.Point(691, 52);
            this.BttClear.Name = "BttClear";
            this.BttClear.Size = new System.Drawing.Size(75, 23);
            this.BttClear.TabIndex = 5;
            this.BttClear.Text = "Clear Chat";
            this.BttClear.UseVisualStyleBackColor = false;
            this.BttClear.Click += new System.EventHandler(this.BttClear_Click);
            // 
            // PctLogoChat
            // 
            this.PctLogoChat.Image = ((System.Drawing.Image)(resources.GetObject("PctLogoChat.Image")));
            this.PctLogoChat.Location = new System.Drawing.Point(12, 12);
            this.PctLogoChat.Name = "PctLogoChat";
            this.PctLogoChat.Size = new System.Drawing.Size(91, 91);
            this.PctLogoChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLogoChat.TabIndex = 3;
            this.PctLogoChat.TabStop = false;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.Color.White;
            this.LblUsername.Location = new System.Drawing.Point(109, 42);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(0, 31);
            this.LblUsername.TabIndex = 4;
            // 
            // BttClose
            // 
            this.BttClose.BackColor = System.Drawing.Color.White;
            this.BttClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BttClose.ForeColor = System.Drawing.Color.Black;
            this.BttClose.Location = new System.Drawing.Point(750, 12);
            this.BttClose.Name = "BttClose";
            this.BttClose.Size = new System.Drawing.Size(20, 20);
            this.BttClose.TabIndex = 2;
            this.BttClose.Text = "X";
            this.BttClose.UseVisualStyleBackColor = false;
            this.BttClose.Click += new System.EventHandler(this.BttClose_Click);
            // 
            // PnlMessage
            // 
            this.PnlMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.PnlMessage.Controls.Add(this.BttSendMessage);
            this.PnlMessage.Controls.Add(this.TxtMessage);
            this.PnlMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlMessage.Location = new System.Drawing.Point(0, 1032);
            this.PnlMessage.Name = "PnlMessage";
            this.PnlMessage.Size = new System.Drawing.Size(778, 121);
            this.PnlMessage.TabIndex = 2;
            // 
            // BttSendMessage
            // 
            this.BttSendMessage.BackColor = System.Drawing.Color.White;
            this.BttSendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BttSendMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.BttSendMessage.FlatAppearance.BorderSize = 12;
            this.BttSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttSendMessage.ForeColor = System.Drawing.Color.Black;
            this.BttSendMessage.Location = new System.Drawing.Point(641, 38);
            this.BttSendMessage.Name = "BttSendMessage";
            this.BttSendMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BttSendMessage.Size = new System.Drawing.Size(78, 45);
            this.BttSendMessage.TabIndex = 1;
            this.BttSendMessage.Text = "Send";
            this.BttSendMessage.UseVisualStyleBackColor = false;
            this.BttSendMessage.Click += new System.EventHandler(this.BttSendMessage_Click);
            // 
            // TxtMessage
            // 
            this.TxtMessage.BackColor = System.Drawing.Color.White;
            this.TxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMessage.ForeColor = System.Drawing.Color.Gray;
            this.TxtMessage.Location = new System.Drawing.Point(66, 38);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(509, 45);
            this.TxtMessage.TabIndex = 0;
            this.TxtMessage.Text = "Enter Message...";
            this.TxtMessage.Click += new System.EventHandler(this.TxtMessage_Click);
            // 
            // PnlConversation
            // 
            this.PnlConversation.Controls.Add(this.LstConversation);
            this.PnlConversation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlConversation.Location = new System.Drawing.Point(0, 120);
            this.PnlConversation.Name = "PnlConversation";
            this.PnlConversation.Size = new System.Drawing.Size(778, 912);
            this.PnlConversation.TabIndex = 3;
            // 
            // LstConversation
            // 
            this.LstConversation.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstConversation.FormattingEnabled = true;
            this.LstConversation.HorizontalScrollbar = true;
            this.LstConversation.ItemHeight = 33;
            this.LstConversation.Location = new System.Drawing.Point(12, 21);
            this.LstConversation.Name = "LstConversation";
            this.LstConversation.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LstConversation.Size = new System.Drawing.Size(754, 862);
            this.LstConversation.TabIndex = 1;
            // 
            // FrmUTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 1153);
            this.Controls.Add(this.PnlConversation);
            this.Controls.Add(this.PnlMessage);
            this.Controls.Add(this.PnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUTB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlTopBar.ResumeLayout(false);
            this.PnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogoChat)).EndInit();
            this.PnlMessage.ResumeLayout(false);
            this.PnlMessage.PerformLayout();
            this.PnlConversation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTopBar;
        private System.Windows.Forms.Button BttClose;
        private System.Windows.Forms.Panel PnlMessage;
        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.Button BttSendMessage;
        private System.Windows.Forms.PictureBox PctLogoChat;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Button BttClear;
        private System.Windows.Forms.Panel PnlConversation;
        private System.Windows.Forms.ListBox LstConversation;
    }
}

