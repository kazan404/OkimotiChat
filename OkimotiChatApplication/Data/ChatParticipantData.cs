using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OkimotiChatApplication.Data
{
    public class ChatParticipantData
    {
        private int ID { get; set; }
        private string Name { get; set; }

        private ChatParticipantData()
        {

        }

        public static ChatParticipantData Create(int id, string name)
        {
            ChatParticipantData chatParticipantData = new ChatParticipantData();

            chatParticipantData.ID = id;
            chatParticipantData.Name = name;

            return chatParticipantData;

        }
        public bool IsIDName(int id)
        {
            return (ID == id);
        }

        public string GetName()
        {
            return Name;
        }
    }
}
