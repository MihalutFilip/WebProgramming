using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxLabServerSide.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        public LaptopEnums.Price Price { get; set;}
        public LaptopEnums.Brand Brand { get; set; }
        public LaptopEnums.Memory Memory { get; set; }
        public LaptopEnums.Processor Processor { get; set; }
        public LaptopEnums.Rating Rating { get; set; }
        public LaptopEnums.Storage Storage { get; set; }
        public LaptopEnums.Type Type { get; set; }
        public LaptopEnums.VideoCard VideoCard { get; set; }
    }
}