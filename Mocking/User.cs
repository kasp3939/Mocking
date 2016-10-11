using System;

namespace Mocking
{
    public class User : ILoginModule
    {
        public int NumMessagesCreated { get; internal set; }
        public string Password { get; internal set; }
        public object Rights { get; internal set; }
        public string UserName { get; internal set; }

        public string ViewAllEmployees()
        {
            return "Here is the list";
        }
        public void Login(User user)
        {
            throw new NotImplementedException();
        }

        public void Register(User user)
        {
            throw new NotImplementedException();
        }

        public void ResendPassword(User user)
        {
            throw new NotImplementedException();
        }

        public void EditEmployeeName(string name, string v)
        {
            throw new NotImplementedException();
        }

        internal void EditEmployeeWage(int wage, int v)
        {
            throw new NotImplementedException();
        }
    }
}