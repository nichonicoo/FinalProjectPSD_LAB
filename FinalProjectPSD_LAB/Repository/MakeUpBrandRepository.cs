using FinalProjectPSD_LAB.Factory;
using FinalProjectPSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Repository
{
    public class MakeUpBrandRepository
    {
        public static Database_MakeMeUpzzEntities db = new Database_MakeMeUpzzEntities();

        public static void CreateMakeUpBrand(int makeupbrandID, string makeupbrandName, int makeupbrandRating)
        {
            MakeupBrand makeupbrand = MakeupBrandFactory.CreateMakeupBrand(makeupbrandID, makeupbrandName, makeupbrandRating);
            db.MakeupBrands.Add(makeupbrand);
            db.SaveChanges();
        }
    }
}