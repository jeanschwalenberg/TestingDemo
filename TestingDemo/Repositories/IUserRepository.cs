using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestingDemo.Models;

namespace TestingDemo.Repositories
{
    public interface IUserRepository {
        void Add(User newUser);
        User FetchByLoginName(string loginName);
        void SubmitChanges();
    }
}