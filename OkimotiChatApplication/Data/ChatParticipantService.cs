using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OkimotiChatApplication.Data
{
    public class ChatParticipantService
    {
        List<ChatParticipantData> chatParticipantDatas = new List<ChatParticipantData>();

        public void SubmitParticipant(int id, string name)
        {
            chatParticipantDatas.Add(ChatParticipantData.Create(id, name));
        }

        public string GetRoomParticipant()
        {
            List<string> participantStrings = chatParticipantDatas.ConvertAll<string>(data => data.GetName());
            return String.Join(", ", participantStrings.Distinct());
        }

        public void DeleteParticipant(int id)
        {
            int deleteIndex = chatParticipantDatas.FindIndex(data => data.IsIDName(id) == true);
            chatParticipantDatas.RemoveAt(deleteIndex);
        }
    }
}
