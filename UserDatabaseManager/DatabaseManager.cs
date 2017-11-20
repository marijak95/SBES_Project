using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UserDatabaseManager
{
    public class DatabaseManager
    {
       
        public bool AddUser(User user)
        {
            if (AlreadyExists(user.Username) == false)
            {
                using(var access = new AccessDB())
                {
                    access.ListOfUsers.Add(user);
                    int i = access.SaveChanges();
                    if (i > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ChangePassword(User user, string newPassword)
        {
            using (var access = new AccessDB())
            {
                foreach(User u in access.ListOfUsers)
                {
                    if(u.Username == user.Username)
                    {
                        u.Password = newPassword;
                        break;
                    }
                        
                }
                int i = access.SaveChanges();
                if (i > 0)
                 {
                        return true;
                 }
            }
            return false;
        }

        public bool AlreadyExists(string username)
        {
            using (var access = new AccessDB()) {
                var q = from b in access.ListOfUsers
                        where b.Username == username
                        select b;

                if (q.Any())
                {
                    return true;
                }
            }
            return false;
        }

        public bool AddGroup(string username, string group)
        {
            using (var access = new AccessDB())
            {
                foreach (User u in access.ListOfUsers)
                {
                    if (u.Username == username)
                    {
                        u.Group = group;
                        break;
                    }

                }
                int i = access.SaveChanges();
                if (i > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AddRequest(int userId, string content)
        {
            Request req = new Request();
            req.Content = content;
            req.UserId = userId;
            req.Approved = false;
            using (var access = new AccessDB())
            {
                access.ListOfRequests.Add(req);
                int i = access.SaveChanges();
                if (i > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ApproveRequest(int id)
        {
            using (var access = new AccessDB())
            {
                foreach(Request r in access.ListOfRequests)
                {
                    if(r.Id == id)
                    {
                        r.Approved = true;
                        break;
                    }
                }
                int i = access.SaveChanges();
                if (i > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
