using System;
using Common;

namespace Server
{
    public class WorkgroupService : IWorkgroupService
    {
        public void AddUser(string username, string firstName, string lastName, string password, string questionOne, string questionTwo, string answerOne, string answerTwo)
        {
            throw new NotImplementedException();
        }

        public void ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void Login(string username, string password, string answerOne, string answerTwo)
        {
            throw new NotImplementedException();
        }

        public void Logout(string username)
        {
            throw new NotImplementedException();
        }
    }
}
