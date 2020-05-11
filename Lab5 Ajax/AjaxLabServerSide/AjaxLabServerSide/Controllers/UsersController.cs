using AjaxLabServerSide.Models;
using AjaxLabServerSide.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AjaxLabServerSide.Controllers
{
    public class UsersController : ApiController
    {
        UserRepository repository = new UserRepository();

        // GET api/Users
        public IEnumerable<User> Get()
        {
            return repository.GetUsersByPage(0);
        }

        // GET api/Users/5
        public IEnumerable<User> Get(int id)
        {
            return repository.GetUsersByPage(id);
        }

        // POST api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Users/5
        public void Delete(int id)
        {
        }
    }
}
