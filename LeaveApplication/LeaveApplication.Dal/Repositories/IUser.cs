using LeaveApplication.Dal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApplication.Dal.Repositories
{
    public interface IUser
    {
        void SetDate(DateTime _DateTime);
        void Add(User _User);
        // List<User> GetUsers { get; }
        //User GetUser(int Id);
        //void Remove(int Id);
        
        
    }
}
