using FinalProjectPSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace FinalProjectPSD_LAB.Repository
{
    public class DatabaseSingleton
    {
        public static Database_MakeMeUpzzEntities db = new Database_MakeMeUpzzEntities();

        public static Database_MakeMeUpzzEntities getInstance()
        {
            if (db == null)
            {
                db = new Database_MakeMeUpzzEntities();
            }
            return db;
        }
    }
}