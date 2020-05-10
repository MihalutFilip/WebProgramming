using AjaxLabServerSide.Models;
using AjaxLabServerSide.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AjaxLabServerSide.Controllers
{
    public class Xand0Controller : ApiController
    {
        Xand0Repository repository = new Xand0Repository();

        // GET api/Xand0
        public IEnumerable<Xand0> Get()
        {
            return repository.GetXAnd0();
        }

        // GET api/Xand0/5
        public IEnumerable<Xand0> Get(int id)
        {
            return repository.GetXAnd0();
        }

        [HttpPost]
        [AllowAnonymous]
        // POST api/Xand0
        public Xand0 Post([FromBody]Xand0 xand0)
        {
            return repository.SaveNextMove(xand0.Id);
        }

        // PUT api/Xand0/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Xand0/5
        public void Delete()
        {
        }
    }
}