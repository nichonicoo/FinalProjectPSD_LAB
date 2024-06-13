using FinalProjectPSD_LAB.Factory;
using FinalProjectPSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Repository
{
    public class MakeupRepository
    {
        public static Database_MakeMeUpzzEntities db = DatabaseSingleton.getInstance();

        public static void CreateMakeup(string makeupName, int makeupPrice, int makeupWeight,int makeuptypeID,int makeupbrandID)
        {
            Makeup newMakeUP = MakeupFactory.CreateMakeUp(makeupName, makeupPrice, makeupWeight, makeuptypeID, makeupbrandID);
            db.Makeups.Add(newMakeUP);
            db.SaveChanges();
        }

        public static Makeup FindByName(string name)
        {
            Makeup makeups = db.Makeups.Where(x => x.MakeupName == name).FirstOrDefault();
            return makeups;
        }

        public static Makeup FindByUser(int id)
        {
            Makeup makeups = db.Makeups.Where(x => x.MakeupID == id).FirstOrDefault();
            return makeups;
        }

        public static void UpdateMakeup(string makeupName, int makeupPrice, int makeupWeight, int makeuptypeID, int makeupbrandID)
        {
            Makeup makeups = FindByName(makeupName);
            makeups.MakeupName = makeupName;
            makeups.MakeupPrice = makeupPrice;
            makeups.MakeupWeight = makeupWeight;
            makeups.MakeupTypeID = makeuptypeID;
            makeups.MakeupBrandID = makeupbrandID;
            db.SaveChanges();   
        }

        public static void DeleteUser(string name )
        {
            db.Makeups.Remove(FindByName(name));
            db.SaveChanges();
        }

        public static List<Makeup> GetMakeup()
        {
            return db.Makeups.ToList();
        }

    }
}