using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestingDemo.Models;
using TestingDemo.Repositories;

namespace TestingDemo.Repositories
{
    class FakeRepository : IUserRepository {
        public List<User> Users = new List<User>();
        public bool DidSubmitChanges = false;

        public void Add(User user) {
            Users.Add(user);
        }

        public User FetchByLoginName(string loginName) {
            return Users.First(m => m.LoginName == loginName);
        }

        public void SubmitChanges() {
            DidSubmitChanges = true;
        }
    }
}