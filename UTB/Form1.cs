using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTB
{
    public partial class FrmUTB : Form
    {
        public FrmUTB()
        {
            InitializeComponent();
        }

        private void BttClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void BttSendMessage_Click(object sender, EventArgs e)
        {
            if (TxtMessage.Text != String.Empty && TxtMessage.ForeColor == Color.Black)
            {
                LstConversation.Items.Add(DateTime.Now.ToShortTimeString() + " || Me : " + TxtMessage.Text);
                TxtMessage.Text = "Enter Message...";
                TxtMessage.ForeColor = Color.Gray;
                await Task.Delay(1500);
                string[] article = { "the", "a", "one", "any", "the", };
                string[] noun = { "boy", "girl", "dog", "town", "car", "boat", "cat", };
                string[] verb = { "drove", "jumped", "ran", "walked", "skipped", };
                string[] preposition = { "to", "from", "over", "under", "on", };
                Random rndarticle = new Random();
                Random rndnoun = new Random();
                Random rndverb = new Random();
                Random rndpreposition = new Random();
                int randomarticle = rndarticle.Next(article.Length);
                int randomnoun = rndnoun.Next(noun.Length);
                int randomverb = rndverb.Next(verb.Length);
                int randompreposition = rndpreposition.Next(preposition.Length);
                LstConversation.Items.Add(String.Format(DateTime.Now.ToShortTimeString() + " || UBT : {0} {1} {2} {3}", article[randomarticle], noun[randomnoun], verb[randomverb], preposition[randompreposition]));
            }
        }
        public string Username
        {
            set { LblUsername.Text = value; }
        }

        private void TxtMessage_Click(object sender, EventArgs e)
        {
            if (TxtMessage.ForeColor == Color.Gray)
            {
                TxtMessage.ForeColor = Color.Black;
                TxtMessage.Text = string.Empty;
            }
        }

        private void BttClear_Click(object sender, EventArgs e)
        {
            LstConversation.Items.Clear();
        }
    }
}
