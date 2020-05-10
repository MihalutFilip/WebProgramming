using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AjaxLabServerSide.Models
{
    public class StationRelation
    {
        [Key, Column(Order = 0)]
        public int StartStationId { get; set; }
        [Key, Column(Order = 1)]
        public int StopStationId { get; set; }
    }
}