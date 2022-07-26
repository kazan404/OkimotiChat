using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OkimotiChatApplication.Data
{
    public class ChatOkimotiService
    {
        List<ChatOkimotiData> chatOkimotiDatas = new List<ChatOkimotiData>();

        /// <summary>
        /// お気持ち情報を登録する
        /// </summary>
        /// <param name="id">誰のお気持ちなのかがわかる値</param>
        /// <param name="okimoti">お気持ちの値</param>
        public void SubmitOkimoti(int id, string okimoti)
        {
            chatOkimotiDatas.Add(ChatOkimotiData.Create(id, okimoti));
        }
        /// <summary>
        /// チャットルームに投稿されている全てのお気持ちを受け取る
        /// </summary>
        /// <returns>全てのお気持ちがコンマ区切りで列記された文字列</returns>
        public string GetRoomOkimoti()
        {
            List<string> OkimotiStrings = chatOkimotiDatas.ConvertAll<string>(data => data.GetOkimoti());
            return String.Join(", ", OkimotiStrings.Distinct());
        }
        /// <summary>
        /// お気持ち情報を削除する
        /// </summary>
        /// <param name="id">削除したいお気持ちを持っていた参加者の値</param>
        public void DeleteOkimoti(int id)
        {
            int deleteIndex = chatOkimotiDatas.FindIndex(data => data.IsIDOkimoti(id) == true);
            chatOkimotiDatas.RemoveAt(deleteIndex);
        }

    }
}
