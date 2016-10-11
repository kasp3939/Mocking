using System;
using System.Collections.Generic;

namespace Mocking
{
    public class Mail : IMailModule
    {
        public Mail()
        {
        }

        public string Content { get; set; }

        public void AddToDraft(Mail mail)
        {
            throw new NotImplementedException();
        }

      
        public void AddToSentMessages(Mail mail)
        {
            throw new NotImplementedException();
        }

        public void AddToSentSpam(Mail mail)
        {
            throw new NotImplementedException();
        }

        public List<Mail> GetAllMail()
        {
            throw new NotImplementedException();
        }

        public Mail GetEmailById(int id)
        {
            throw new NotImplementedException();
        }

        public void SendMail(Mail mail, Employee employee)
        {
            throw new NotImplementedException();
        }

        public void SendMailE(Mail message, Employee e)
        {
            throw new NotImplementedException();
        }
    }
}