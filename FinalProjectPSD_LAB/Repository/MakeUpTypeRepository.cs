using FinalProjectPSD_LAB.Factory;
using FinalProjectPSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Repository
{
    public class MakeUpTypeRepository
    {
        public static Database_MakeMeUpzzEntities db = new Database_MakeMeUpzzEntities();

        public static void CreateMakeUpType(int makeuptypeID, string makeuptypeName)
        {
            MakeUpType makeUpType = MakeUpTypeFactory.CreateMakeupType(makeuptypeID, makeuptypeName);
            db.MakeUpTypes.Add(makeUpType);
            db.SaveChanges();
        }
    }
}