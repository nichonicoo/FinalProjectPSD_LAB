using FinalProjectPSD_LAB.Factory;
using FinalProjectPSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Repository
{
    public class TransactionDetailRepository
    {
        public static Database_MakeMeUpzzEntities db = new Database_MakeMeUpzzEntities();

        public static void CreateTransactionDetails(int transactionid, int makeupid, int quantity)
        {
            TransactionDetail transactionDetail = TransactionDetailFactory.CreateTransactionDetail(transactionid, makeupid, quantity);
            db.TransactionDetails.Add(transactionDetail);
            db.SaveChanges();
        }
    }
}