using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestingDemo.Repositories;
using TestingDemo.Models;

namespace TestingDemo.Repositories
{
    public class DefaultUserRepository : IUserRepository {

        public void Add(User newUser) {
            //implement me
        }

        public User FetchByLoginName(string loginName) {
            //implement me
            return new User() { LoginName = loginName };
        }

        public void SubmitChanges() {
            //implement me
        }
    }
}