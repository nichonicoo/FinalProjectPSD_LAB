using FinalProjectPSD_LAB.Factory;
using FinalProjectPSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace FinalProjectPSD_LAB.Repository
{
    public class UserRepository
    {
        public static Database_MakeMeUpzzEntities db = DatabaseSingleton.getInstance();

        public static void CreateUser(string name, string email, string gender, string dob, string password,string role)
        {
            User newUser = UserFactory.CreateUser(name, email, gender, dob, password, role);
            db.Users.Add(newUser);
            db.SaveChanges();
            db.SaveChanges();
        }

        public static User FindByName(string name)
        {
            User user = db.Users.Where(x => x.Username == name).ToList().FirstOrDefault();
            return user;
        }

        public static User FindByID(int id)
        {
            User user = db.Users.Where(x => x.UserID == id).ToList().FirstOrDefault();
            return user;
        }

        public static void UpdateUser(string name, string email, string gender, string dob, string password, string role)
        {
            User user = FindByName(name);
            user.Username = name;
            user.UserEmail = email;
            user.UserGender = gender;
            user.UserDOB = DateTime.Parse(dob);
            user.UserPassword = password;
            user.UserRole = role;
            db.SaveChanges();
        }

        public static void DeleteUser(string name)
        {
            db.Users.Remove(FindByName(name));
            db.SaveChanges();
        }

        public static List<User> GetUsers()
        {
            return db.Users.ToList();
        }
    }
}