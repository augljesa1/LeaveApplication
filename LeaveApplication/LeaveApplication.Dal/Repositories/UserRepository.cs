using LeaveApplication.Dal.Context;
using LeaveApplication.Dal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApplication.Dal.Repositories
{
    public class UserRepository : IUser
    {
        private LeaveAppDbContext db;

        public UserRepository(LeaveAppDbContext _db)
        {
            db = _db;
        }

        public void Add(User _User)
        {
            db.Users.Add(_User);
        }

        public void SetDate(DateTime _DateTime)
        {
            db.Users.Add(_DateTime);
        }
    }
}
