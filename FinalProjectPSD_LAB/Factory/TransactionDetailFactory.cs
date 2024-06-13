using FinalProjectPSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail CreateTransactionDetail(int transactionid, int makeupid,int quantity)
        {
            TransactionDetail newTransactionDetail = new TransactionDetail()
            {
                TransactionID = transactionid,
                MakeupID = makeupid,
                Quantity = quantity
            };
            return newTransactionDetail;
        }
    }
}