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
    public class TeacherController : ApiController
    {
        TeacherRepository repository = new TeacherRepository();

        // GET api/Teacher
        public IEnumerable<int> Get()
        {
            return repository.GetTeachersIDs();
        }

        // GET api/Teacher/5
        public Teacher Get(int id)
        {
            // this will get the list of IDs of Teacher
            return repository.GetTeacher(id);
        }

        // POST api/Teacher
        public void Post([FromBody]Teacher teacher)
        {
            repository.Update(teacher);
        }

        // PUT api/Teacher/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Teacher/5
        public void Delete(int id)
        {
        }
    }
}
