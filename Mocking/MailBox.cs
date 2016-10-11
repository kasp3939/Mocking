using System;

namespace Mocking
{
    internal class MailBox
    {
        public MailBox()
        {
        }

        public int NumReceivedMessages { get; set; }

        internal void Add(System.Net.Mail o)
        {
            throw new NotImplementedException();
        }

        internal string GetLatestMessageText()
        {
            throw new NotImplementedException();
        }

        internal void Add(Mail o)
        {
            throw new NotImplementedException();
        }
    }
}