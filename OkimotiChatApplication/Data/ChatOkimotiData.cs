using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OkimotiChatApplication.Data
{
    public class ChatOkimotiData
    {
        private int     ID      { get; set; }
        private string  Okimoti { get; set; }

        private ChatOkimotiData()
        {

        }

        public static ChatOkimotiData Create(int id, string okimoti)
        {
            ChatOkimotiData chatOkimotiData = new ChatOkimotiData();

            chatOkimotiData.ID = id;
            chatOkimotiData.Okimoti = okimoti;

            return chatOkimotiData;
        }

        public void ChangeOkimoti(string okimoti)
        {
            Okimoti = okimoti;
        }

        public bool IsIDOkimoti(int id)
        {
            return (ID == id);
        }

        public string GetOkimoti()
        {
            return Okimoti;
        }

    }
}
