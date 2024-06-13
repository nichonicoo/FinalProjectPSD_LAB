using FinalProjectPSD_LAB.Model;
using FinalProjectPSD_LAB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Handler
{
    public class UserHandler
    {
        public static void CreateUser(string name, string email, string gender, string dob, string password, string role)
        {
            UserRepository.CreateUser(name, email, gender, dob, password, role);
        }

        public static string Login(string name, string password)
        {
            User user = UserRepository.FindByName(name);
            if(user == null)
            {
                return "User does not exist. Please register and try again";
            }else if(user.UserPassword != password)
            {
                return "Wrong Password";
            }
            else
            {
                return user.UserRole;
            }
        } 

        public static void UpdateUser(string name, string email, string gender, string dob, string password, string role)
        {
            UserRepository.UpdateUser(name, email,gender,dob,password,role);
        }

        public static void DeleteUser(string name)
        {
            UserRepository.DeleteUser(name);
        }
        public static User GetUser(string name)
        {
            return UserRepository.FindByName(name);
        }
        public static List<User> GetUsers()
        {
            return UserRepository.GetUsers();
        }
    }
}