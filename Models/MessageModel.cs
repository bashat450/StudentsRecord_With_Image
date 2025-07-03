using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsCRUDWithImageMVC.Models
{
    public class MessageModel
    {
        public int MessageId { get; set; }
        public string SenderEmail { get; set; }
        public string ReceiverEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SentDate { get; set; }
    }
}