using AjaxLabServerSide.Context;
using AjaxLabServerSide.Controllers;
using AjaxLabServerSide.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjaxLabServerSide.Repository
{
    public class InitializerContext : DropCreateDatabaseAlways<AjaxContext>
    {
        protected override void Seed(AjaxContext context)
        {
            IList<Station> defaultStations = new List<Station>();
            IList<StationRelation> stationRelations = new List<StationRelation>();
            IList<User> users = new List<User>();
            IList<Xand0> xand0 = new List<Xand0>();
            IList<Teacher> teachers = new List<Teacher>();
            IList<Laptop> laptops = new List<Laptop>();

            defaultStations.Add(new Station() { Id = 1, Name = "Cluj"});
            defaultStations.Add(new Station() { Id = 2, Name = "Timisoara"});
            defaultStations.Add(new Station() { Id = 3, Name = "Iasi"});
            defaultStations.Add(new Station() { Id = 4, Name = "Suceava"});

            stationRelations.Add(new StationRelation() { StartStationId = 1, StopStationId = 2 });
            stationRelations.Add(new StationRelation() { StartStationId = 1, StopStationId = 4 });
            stationRelations.Add(new StationRelation() { StartStationId = 4, StopStationId = 2 });
            stationRelations.Add(new StationRelation() { StartStationId = 4, StopStationId = 3 });
            stationRelations.Add(new StationRelation() { StartStationId = 2, StopStationId = 3 });

            
            users.Add(new User() { Id = 1, Email = "mihalutfilip@yahoo.com", FirstName = "Filip", LastName = "Mihalut", Phone = "0747824021" });
            users.Add(new User() { Id = 2, Email = "sebi@yahoo.com", FirstName = "Sebi", LastName = "Mihai", Phone = "0742824021" });
            users.Add(new User() { Id = 3, Email = "alexandru@yahoo.com", FirstName = "Alexandru", LastName = "Mihalut", Phone = "0747824021" });
            users.Add(new User() { Id = 4, Email = "anamariamihai@yahoo.com", FirstName = "Anamaria", LastName = "Mihai", Phone = "0747824021" });
            users.Add(new User() { Id = 5, Email = "ghemucrina@yahoo.com", FirstName = "Crina", LastName = "Ghemu", Phone = "0747822131" });
            users.Add(new User() { Id = 6, Email = "elena@yahoo.com", FirstName = "Elena", LastName = "Mihalut", Phone = "0747824021" });
            users.Add(new User() { Id = 7, Email = "filipchiriac@yahoo.com", FirstName = "Filip", LastName = "Chiriac", Phone = "0727824021" });
            users.Add(new User() { Id = 8, Email = "andreicotan@yahoo.com", FirstName = "Andrei", LastName = "Cotan", Phone = "0123824021" });

            xand0.Add(new Xand0() { Id = 1 });
            xand0.Add(new Xand0() { Id = 2 });
            xand0.Add(new Xand0() { Id = 3 });
            xand0.Add(new Xand0() { Id = 4 });
            xand0.Add(new Xand0() { Id = 5 });
            xand0.Add(new Xand0() { Id = 6 });
            xand0.Add(new Xand0() { Id = 7 });
            xand0.Add(new Xand0() { Id = 8 });
            xand0.Add(new Xand0() { Id = 9 });

            teachers.Add(new Teacher() { Id = 1, Name = "Alex" });
            teachers.Add(new Teacher() { Id = 2, Name = "Mihai" });
            teachers.Add(new Teacher() { Id = 3, Name = "Andreea"});
            teachers.Add(new Teacher() { Id = 4, Name = "Adrian" });

            laptops.Add(new Laptop()
            {
                Id = 1,
                Brand = LaptopEnums.Brand.Accer,
                Memory = LaptopEnums.Memory.Beetwen12GBand16GB,
                Price = LaptopEnums.Price.High,
                Processor = LaptopEnums.Processor.IntelCorei3,
                Rating = LaptopEnums.Rating.Fifth,
                Storage = LaptopEnums.Storage.HDD,
                Type = LaptopEnums.Type.Business,
                VideoCard = LaptopEnums.VideoCard.Dedicated
            });

            laptops.Add(new Laptop()
            {
                Id = 2,
                Brand = LaptopEnums.Brand.Apple,
                Memory = LaptopEnums.Memory.Beetwen6GBand8GB,
                Price = LaptopEnums.Price.Medium,
                Processor = LaptopEnums.Processor.IntelCeleron,
                Rating = LaptopEnums.Rating.First,
                Storage = LaptopEnums.Storage.HDDSDD,
                Type = LaptopEnums.Type.Gaming,
                VideoCard = LaptopEnums.VideoCard.Integrated
            });

            laptops.Add(new Laptop()
            {
                Id = 3,
                Brand = LaptopEnums.Brand.Asus,
                Memory = LaptopEnums.Memory.GB4,
                Price = LaptopEnums.Price.Low,
                Processor = LaptopEnums.Processor.IntelCorei3,
                Rating = LaptopEnums.Rating.Forth,
                Storage = LaptopEnums.Storage.SSD,
                Type = LaptopEnums.Type.Home,
                VideoCard = LaptopEnums.VideoCard.Dedicated
            });

            laptops.Add(new Laptop()
            {
                Id = 4,
                Brand = LaptopEnums.Brand.Dell,
                Memory = LaptopEnums.Memory.LessThan4GB,
                Price = LaptopEnums.Price.Medium,
                Processor = LaptopEnums.Processor.IntelCeleron,
                Rating = LaptopEnums.Rating.Second,
                Storage = LaptopEnums.Storage.HDD,
                Type = LaptopEnums.Type.Ultraportable,
                VideoCard = LaptopEnums.VideoCard.Integrated
            });

            laptops.Add(new Laptop()
            {
                Id = 5,
                Brand = LaptopEnums.Brand.HP,
                Memory = LaptopEnums.Memory.MoreThan16GB,
                Price = LaptopEnums.Price.High,
                Processor = LaptopEnums.Processor.IntelCorei7,
                Rating = LaptopEnums.Rating.Third,
                Storage = LaptopEnums.Storage.SSD,
                Type = LaptopEnums.Type.Business,
                VideoCard = LaptopEnums.VideoCard.Integrated
            });

            laptops.Add(new Laptop()
            {
                Id = 6,
                Brand = LaptopEnums.Brand.Huawei,
                Memory = LaptopEnums.Memory.GB4,
                Price = LaptopEnums.Price.Low,
                Processor = LaptopEnums.Processor.IntelCorei9,
                Rating = LaptopEnums.Rating.First,
                Storage = LaptopEnums.Storage.HDDSDD,
                Type = LaptopEnums.Type.Gaming,
                VideoCard = LaptopEnums.VideoCard.Integrated
            });

            laptops.Add(new Laptop()
            {
                Id = 7,
                Brand = LaptopEnums.Brand.Lenovo,
                Memory = LaptopEnums.Memory.Beetwen12GBand16GB,
                Price = LaptopEnums.Price.High,
                Processor = LaptopEnums.Processor.IntelPentium,
                Rating = LaptopEnums.Rating.Forth,
                Storage = LaptopEnums.Storage.SSD,
                Type = LaptopEnums.Type.Home,
                VideoCard = LaptopEnums.VideoCard.Dedicated
            });

            laptops.Add(new Laptop()
            {
                Id = 8,
                Brand = LaptopEnums.Brand.Microsoft,
                Memory = LaptopEnums.Memory.Beetwen6GBand8GB,
                Price = LaptopEnums.Price.Low,
                Processor = LaptopEnums.Processor.IntelCeleron,
                Rating = LaptopEnums.Rating.First,
                Storage = LaptopEnums.Storage.SSD,
                Type = LaptopEnums.Type.Home,
                VideoCard = LaptopEnums.VideoCard.Dedicated
            });

            laptops.Add(new Laptop()
            {
                Id = 9,
                Brand = LaptopEnums.Brand.Lenovo,
                Memory = LaptopEnums.Memory.GB4,
                Price = LaptopEnums.Price.Low,
                Processor = LaptopEnums.Processor.IntelCorei3,
                Rating = LaptopEnums.Rating.First,
                Storage = LaptopEnums.Storage.SSD,
                Type = LaptopEnums.Type.Home,
                VideoCard = LaptopEnums.VideoCard.Dedicated
            });

            laptops.Add(new Laptop()
            {
                Id = 10,
                Brand = LaptopEnums.Brand.Huawei,
                Memory = LaptopEnums.Memory.LessThan4GB,
                Price = LaptopEnums.Price.Medium,
                Processor = LaptopEnums.Processor.IntelCorei5,
                Rating = LaptopEnums.Rating.Forth,
                Storage = LaptopEnums.Storage.HDDSDD,
                Type = LaptopEnums.Type.Gaming,
                VideoCard = LaptopEnums.VideoCard.Integrated
            });

            laptops.Add(new Laptop()
            {
                Id = 11,
                Brand = LaptopEnums.Brand.Accer,
                Memory = LaptopEnums.Memory.GB4,
                Price = LaptopEnums.Price.High,
                Processor = LaptopEnums.Processor.IntelCeleron,
                Rating = LaptopEnums.Rating.Fifth,
                Storage = LaptopEnums.Storage.HDD,
                Type = LaptopEnums.Type.Business,
                VideoCard = LaptopEnums.VideoCard.Dedicated
            });

            laptops.Add(new Laptop()
            {
                Id = 12,
                Brand = LaptopEnums.Brand.Apple,
                Memory = LaptopEnums.Memory.MoreThan16GB,
                Price = LaptopEnums.Price.Medium,
                Processor = LaptopEnums.Processor.IntelPentium,
                Rating = LaptopEnums.Rating.First,
                Storage = LaptopEnums.Storage.HDDSDD,
                Type = LaptopEnums.Type.Ultraportable,
                VideoCard = LaptopEnums.VideoCard.Integrated
            });

            laptops.Add(new Laptop()
            {
                Id = 13,
                Brand = LaptopEnums.Brand.Asus,
                Memory = LaptopEnums.Memory.LessThan4GB,
                Price = LaptopEnums.Price.Medium,
                Processor = LaptopEnums.Processor.IntelCorei9,
                Rating = LaptopEnums.Rating.First,
                Storage = LaptopEnums.Storage.HDD,
                Type = LaptopEnums.Type.Home,
                VideoCard = LaptopEnums.VideoCard.Dedicated
            });

            laptops.Add(new Laptop()
            {
                Id = 14,
                Brand = LaptopEnums.Brand.Dell,
                Memory = LaptopEnums.Memory.LessThan4GB,
                Price = LaptopEnums.Price.Medium,
                Processor = LaptopEnums.Processor.IntelCorei7,
                Rating = LaptopEnums.Rating.Second,
                Storage = LaptopEnums.Storage.HDD,
                Type = LaptopEnums.Type.Gaming,
                VideoCard = LaptopEnums.VideoCard.Integrated
            });

            laptops.Add(new Laptop()
            {
                Id = 15,
                Brand = LaptopEnums.Brand.HP,
                Memory = LaptopEnums.Memory.MoreThan16GB,
                Price = LaptopEnums.Price.High,
                Processor = LaptopEnums.Processor.IntelCorei7,
                Rating = LaptopEnums.Rating.Third,
                Storage = LaptopEnums.Storage.SSD,
                Type = LaptopEnums.Type.Business,
                VideoCard = LaptopEnums.VideoCard.Dedicated
            });

            laptops.Add(new Laptop()
            {
                Id = 16,
                Brand = LaptopEnums.Brand.Huawei,
                Memory = LaptopEnums.Memory.Beetwen6GBand8GB,
                Price = LaptopEnums.Price.Low,
                Processor = LaptopEnums.Processor.IntelCorei9,
                Rating = LaptopEnums.Rating.First,
                Storage = LaptopEnums.Storage.HDDSDD,
                Type = LaptopEnums.Type.Gaming,
                VideoCard = LaptopEnums.VideoCard.Integrated
            });

            laptops.Add(new Laptop()
            {
                Id = 17,
                Brand = LaptopEnums.Brand.Lenovo,
                Memory = LaptopEnums.Memory.Beetwen12GBand16GB,
                Price = LaptopEnums.Price.Low,
                Processor = LaptopEnums.Processor.IntelPentium,
                Rating = LaptopEnums.Rating.Forth,
                Storage = LaptopEnums.Storage.HDDSDD,
                Type = LaptopEnums.Type.Home,
                VideoCard = LaptopEnums.VideoCard.Dedicated
            });

            laptops.Add(new Laptop()
            {
                Id = 18,
                Brand = LaptopEnums.Brand.Microsoft,
                Memory = LaptopEnums.Memory.Beetwen6GBand8GB,
                Price = LaptopEnums.Price.Low,
                Processor = LaptopEnums.Processor.IntelCorei9,
                Rating = LaptopEnums.Rating.First,
                Storage = LaptopEnums.Storage.SSD,
                Type = LaptopEnums.Type.Home,
                VideoCard = LaptopEnums.VideoCard.Dedicated
            });

            laptops.Add(new Laptop()
            {
                Id = 19,
                Brand = LaptopEnums.Brand.Lenovo,
                Memory = LaptopEnums.Memory.LessThan4GB,
                Price = LaptopEnums.Price.Low,
                Processor = LaptopEnums.Processor.IntelCorei3,
                Rating = LaptopEnums.Rating.First,
                Storage = LaptopEnums.Storage.SSD,
                Type = LaptopEnums.Type.Home,
                VideoCard = LaptopEnums.VideoCard.Dedicated
            });

            laptops.Add(new Laptop()
            {
                Id = 20,
                Brand = LaptopEnums.Brand.Huawei,
                Memory = LaptopEnums.Memory.LessThan4GB,
                Price = LaptopEnums.Price.Medium,
                Processor = LaptopEnums.Processor.IntelCorei9,
                Rating = LaptopEnums.Rating.Forth,
                Storage = LaptopEnums.Storage.HDDSDD,
                Type = LaptopEnums.Type.Gaming,
                VideoCard = LaptopEnums.VideoCard.Integrated
            });



            context.Stations.AddRange(defaultStations);
            context.StationRelations.AddRange(stationRelations);
            context.Users.AddRange(users);
            context.Xand0s.AddRange(xand0);
            context.Teachers.AddRange(teachers);
            context.Laptops.AddRange(laptops);

            base.Seed(context);
        }
    }
}