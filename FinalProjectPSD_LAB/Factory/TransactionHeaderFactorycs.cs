using FinalProjectPSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Factory
{
    public class TransactionHeaderFactorycs
    {
        public static TransactionHeader CreateTransactionHeader(int transactionID, int userID, DateTime transactiondate, string status)
        {
            TransactionHeader newTransactionHeader = new TransactionHeader()
            {
                TransactionID = transactionID,
                UserID = userID,
                TransactionDate = transactiondate,
                Status = status
            };
            return newTransactionHeader;
        }
    }
}