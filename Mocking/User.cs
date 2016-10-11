using System;

namespace Mocking
{
    public class User
    {
        public int NumMessagesCreated { get; internal set; }
        public string Password { get; internal set; }
        public object Rights { get; internal set; }
        public string UserName { get; internal set; }

        internal string ViewAllEmployees()
        {
            throw new NotImplementedException();
        }
    }
}