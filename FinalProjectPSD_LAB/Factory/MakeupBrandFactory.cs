using FinalProjectPSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Factory
{
    public class MakeupBrandFactory
    {
        public static MakeupBrand CreateMakeupBrand(int makeupbrandID, string makeupbrandName, int makeupbrandRating)
        {
            MakeupBrand newMakeupBrand = new MakeupBrand()
            {
                MakeupBrandID = makeupbrandID,
                MakeupBrandName = makeupbrandName,
                MakeupBrandRating = makeupbrandRating
            }; return newMakeupBrand;
        }
    }
}