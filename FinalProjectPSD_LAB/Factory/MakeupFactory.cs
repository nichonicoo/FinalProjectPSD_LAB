using FinalProjectPSD_LAB.Model;
using FinalProjectPSD_LAB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Factory
{
    public class MakeupFactory
    {
        public static int CreateID()
        {
            Database_MakeMeUpzzEntities db = DatabaseSingleton.getInstance();
            int id = 1;
            if(db.Makeups != null)
            {
                id = db.Makeups.Last().MakeupID;
                id++;
            }
            return id;
        }

        public static Makeup CreateMakeUp(string makeupname, int makeupprice, int makeupweight, int makeuptypeID, int makeupbrandID)
        {
            int newID = CreateID();
            Makeup newMakeUp = new Makeup()
            {
                MakeupID = newID,
                MakeupName = makeupname,
                MakeupPrice = makeupprice,
                MakeupWeight = makeupweight,
                MakeupTypeID = makeuptypeID,
                MakeupBrandID = makeupbrandID
            }; return newMakeUp;
        }
    }
}