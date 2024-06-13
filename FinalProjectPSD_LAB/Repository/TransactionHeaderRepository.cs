using FinalProjectPSD_LAB.Factory;
using FinalProjectPSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Repository
{
    public class TransactionHeaderRepository
    {
        public static Database_MakeMeUpzzEntities db = new Database_MakeMeUpzzEntities();

        public static void CreateTransactionHeader(int transactionID, int userID, DateTime transactiondate, string status)
        {
            TransactionHeader transactionHeader = TransactionHeaderFactorycs.CreateTransactionHeader(transactionID, userID, transactiondate, status);   
            db.TransactionHeaders.Add(transactionHeader);
            db.SaveChanges();
        }
    }
}