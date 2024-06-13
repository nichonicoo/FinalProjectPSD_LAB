using FinalProjectPSD_LAB.Model;
using FinalProjectPSD_LAB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Factory
{
    public class UserFactory
    {
        public static int CreateID()
        {
            Database_MakeMeUpzzEntities db = DatabaseSingleton.getInstance();
            int id = 1;
            User LastUser = db.Users.ToList().LastOrDefault();
            if(LastUser != null)
            {
                id = db.Users.ToList().LastOrDefault().UserID;
                id++;
            }
            return id;
        }
        public static User CreateUser(string name, string email, string gender, string dob, string password, string role)
        {
            int newID = CreateID();
            User newUser = new User()
            {
                UserID = newID,
                Username = name,
                UserEmail = email,
                UserGender = gender,
                UserDOB = DateTime.Parse(dob),
                UserPassword = password,
                UserRole = role,
            }; 
            return newUser;
        }
    }
}