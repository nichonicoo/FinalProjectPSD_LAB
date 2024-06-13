using FinalProjectPSD_LAB.Factory;
using FinalProjectPSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Repository
{
    public class CartRepository
    {
        public static Database_MakeMeUpzzEntities db = DatabaseSingleton.getInstance();

        public static void CreateCart(int cartID, int userID, int makeupID,int quantity)
        {
            Cart cart = CartsFactory.CreateCart(cartID, userID, makeupID, quantity);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static Cart FindByID(int cartID, int userID, int makeupID)
        {
            return db.Carts.Find(cartID, userID, makeupID);
        }

        public static void UpdatrCart(int cartID, int userID, int makeupID, int quantity)
        {
            Cart cart = FindByID(cartID, userID, makeupID); 
            cart.Quantity = quantity;
        }

        public static void DeleteCart(int cartID, int userID, int makeupID)
        {
            db.Carts.Remove(FindByID(cartID,userID, makeupID));
        }
    }
}