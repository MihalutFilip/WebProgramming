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
    public class StationsController : ApiController
    {
        StationRepository repository = new StationRepository();

        // GET api/stations
        public IEnumerable<Station> Get()
        {
            return repository.GetStations();
        }

        // GET api/stations/5
        public IEnumerable<Station> Get(int id)
        {
            // this will get the list of IDs of stations
            return repository.GetStationsByRelationId(id);
        }

        // POST api/stations
        public void Post([FromBody]string value)
        {
        }

        // PUT api/stations/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/stations/5
        public void Delete(int id)
        {
        }
    }
}
