

using System;
using System.Web.UI.WebControls;

namespace WooxTravel.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverMail { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}