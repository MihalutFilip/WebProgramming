using AjaxLabServerSide.Controllers;
using AjaxLabServerSide.Models;
using AjaxLabServerSide.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjaxLabServerSide.Context
{
    public partial class AjaxContext : DbContext
    {
        public AjaxContext()
            : base("Data Source=.;Initial Catalog=LabAjax;Integrated Security=True")
        {
            Database.SetInitializer(new InitializerContext());
        }

        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<StationRelation> StationRelations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Xand0> Xand0s { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Laptop> Laptops { get; set; }
    }
}