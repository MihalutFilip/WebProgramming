using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxLabServerSide.Models
{
    public static class LaptopEnums
    {
        public enum Price
        {
            Low = 0,
            Medium = 1,
            High = 2
        }

        public enum Rating
        {
            First = 0,
            Second = 1,
            Third = 2,
            Forth = 3,
            Fifth = 4
        }

        public enum Brand
        {
            Asus = 0,
            HP = 1,
            Lenovo = 2,
            Dell = 3,
            Apple = 4,
            Accer = 5,
            Microsoft = 6,
            Huawei = 7
        }

        public enum Type
        {
            Home = 0,
            Ultraportable = 1,
            Gaming = 2,
            Business = 3
        }

        public enum Processor
        {
            IntelCorei3 = 0,
            IntelCorei5 = 1,
            IntelCorei7 = 2,
            IntelCorei9 = 3,
            IntelCeleron = 4,
            IntelPentium = 5
        }

        public enum Memory
        {
            LessThan4GB = 0,
            GB4 = 1,
            Beetwen6GBand8GB = 2,
            Beetwen12GBand16GB = 3,
            MoreThan16GB = 4
        }

        public enum Storage
        {
            HDD = 0,
            HDDSDD = 1,
            SSD = 2
        }

        public enum VideoCard
        {
            Integrated = 0,
            Dedicated = 1
        }
    }
}