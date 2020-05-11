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
    public class LaptopController : ApiController
    {
        LaptopRepository repository = new LaptopRepository();

        // GET api/Laptops
        public IEnumerable<Laptop> Get()
        {
            return repository.GetLaptops();
        }

        // GET api/Laptops/5
        public IEnumerable<Laptop> Get(int id)
        {
            // this will get the list of IDs of Laptops
            return repository.GetLaptops();
        }

        // POST api/Laptops
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Laptops/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Laptops/5
        public void Delete(int id)
        {
        }
    }
}
