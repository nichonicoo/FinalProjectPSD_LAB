using FinalProjectPSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace FinalProjectPSD_LAB.Factory
{
    public class CartsFactory
    {
        public static Cart CreateCart(int cartID, int userID, int makeupID, int quantity)
        {
            Cart newCart = new Cart()
            {
                CartID = cartID,
                UserID = userID,
                MakeupID = makeupID,
                Quantity = quantity
            }; return newCart;
        }
    }
}