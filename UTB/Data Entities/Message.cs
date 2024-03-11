using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Data_Entities
{
    public class Message
    {
        public int messageId { get; set; }
        public DateTime messageDate { get; set; }
        public string content { get; set; }
        public string category { get; set; }
        public Message() { }

        public int GetMessageId()
        {
            return messageId;
        }

        public void SetMessageId(int id)
        {
            messageId = id;
        }

        public DateTime GetMessageDate()
        {
            return messageDate;
        }

        public void SetMessageDate(DateTime date)
        {
            messageDate = date;
        }

        public string GetContent()
        {
            return content;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }

        public string GetCategory()
        {
            return category;
        }

        public void SetCategory(string category)
        {
            this.category = category;
        }
    }

}
