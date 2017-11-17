using System;
using System.ServiceModel;

namespace Common
{
    [ServiceContract]
    public interface IWorkgroupService
    {
        [OperationContract]
        void AddUser(string username, string firstName, string lastName, string password, string questionOne, string questionTwo, string answerOne, string answerTwo);

        [OperationContract]
        void Login(string username, string password, string answerOne, string answerTwo);

        [OperationContract]
        void Logout(string username);

        [OperationContract]
        void ChangePassword(string username, string oldPassword, string newPassword);
    }
}
