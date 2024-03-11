using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Data_Entities
{

    public class Bot
    {
        public int botId { get; set; }
        public string botName { get; set; }
        public string description { get; set; }

        public Bot()
        {
        }

        public int GetBotId()
        {
            return botId;
        }

        public void SetBotId(int id)
        {
            botId = id;
        }

        public string GetBotName()
        {
            return botName;
        }

        public void SetBotName(string name)
        {
            botName = name;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string desc)
        {
            description = desc;
        }
    }
}
