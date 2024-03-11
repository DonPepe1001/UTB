using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Data_Entities
{
    public class ChatSession
    {
        public int chatSessionId { get; set; }
        public DateTime sessionDate { get; set; }
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }
        public string chatCategory { get; set; }
        public string result { get; set; }


        public string Respond()
        {

            return string.Empty;
        }

        public int GetChatSessionId()
        {

            return 0;
        }

        public void SetChatSessionId(int chatSessionId)
        {

        }

        public DateTime GetSessionDate()
        {

            return DateTime.Now;
        }

        public void SetSessionDate(DateTime sessionDate)
        {

        }

        public TimeSpan GetStartTime()
        {

            return TimeSpan.Zero;
        }

        public void SetStartTime(TimeSpan startTime)
        {

        }

        public TimeSpan GetEndTime()
        {

            return TimeSpan.Zero;
        }

        public void SetEndTime(TimeSpan endTime)
        {

        }

        public string GetChatCategory()
        {

            return string.Empty;
        }

        public void SetChatCategory(string chatCategory)
        {

        }

        public string GetResult()
        {

            return string.Empty;
        }
    }

}
