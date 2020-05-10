using AjaxLabServerSide.Context;
using AjaxLabServerSide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxLabServerSide.Repository
{
    public class UserRepository
    {
        public List<User> GetUsersByPage(int page)
        {
            var result = new List<User>();
            using (var context = new AjaxContext())
            {
                var users = context.Users.ToList();
                result = users.Where(user => page * 3 <= users.IndexOf(user) && users.IndexOf(user) < (page + 1) * 3).ToList();
            }

            return result;
        }
    }
}