using FinalProjectPSD_LAB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Handler
{
    public class MakeupHandler
    {
        public static void CreateMakeup(string makeupName, int makeupPrice, int makeupWeight, int makeuptypeID, int makeupbrandID)
        {
            MakeupRepository.CreateMakeup(makeupName,makeupPrice, makeupWeight, makeuptypeID, makeupbrandID);
        }

        public static void UpdateMakeup(string makeupName, int makeupPrice, int makeupWeight, int makeuptypeID, int makeupbrandID)
        {
            MakeupRepository.UpdateMakeup(makeupName, makeupPrice, makeupWeight, makeuptypeID,makeupbrandID);
        }
        public static void DeleteMakeup(string makeupName)
        {
            MakeupRepository.DeleteUser(makeupName);
        }
    }
}