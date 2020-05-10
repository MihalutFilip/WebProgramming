using AjaxLabServerSide.Context;
using AjaxLabServerSide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxLabServerSide.Repository
{
    public class StationRepository
    {
        public List<Station> GetStations()
        {
            var stations = new List<Station>();
            using (var context = new AjaxContext())
            {
                stations = context.Stations.ToList();
            }

            return stations;
        }

        public List<Station> GetStationsByRelationId(int id)
        {
            var stations = new List<Station>();
            using (var context = new AjaxContext())
            {
                stations = context.Stations.Where(station => 
                    context.StationRelations.Any(relation => relation.StartStationId == id && relation.StopStationId == station.Id)).ToList();
            }

            return stations;
        }
    }
}