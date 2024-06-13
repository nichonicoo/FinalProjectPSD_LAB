using FinalProjectPSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Factory
{
    public class MakeUpTypeFactory
    {
        public static  MakeUpType CreateMakeupType(int makeuptypeID, string makeuptypeName)
        {
            MakeUpType newMakeUpType = new MakeUpType()
            {
                MakeupTypeID = makeuptypeID,
                MakeupTypeName = makeuptypeName
            }; 
            return newMakeUpType;
        }
    }
}