using System;
using System.Collections.Generic;


namespace Mocking
{
    public class MailBox
    {
        public MailBox()
        {
        }

        public int NumReceivedMessages { get; set; }

       
        public void Add(Mail o)
        {
            Mail.Add(o);
            NumReceivedMessages++;
        }

        private List<Mail> Mail = new List<Mail>();
        public string GetLatestMessageText()
        {
            Mail mails = Mail[Mail.Count - 1];
            return mails.Content;
        }
                    
    }
     
}