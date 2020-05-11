using AjaxLabServerSide.Context;
using AjaxLabServerSide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxLabServerSide.Repository
{
    public class LaptopRepository
    {
        public List<Laptop> GetLaptops()
        {
            var laptops = new List<Laptop>();
            using (var context = new AjaxContext())
            {
                laptops = context.Laptops.ToList();
            }

            return laptops;
        }
    }
}