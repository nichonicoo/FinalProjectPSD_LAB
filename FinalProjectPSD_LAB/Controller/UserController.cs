﻿using FinalProjectPSD_LAB.Handler;
using FinalProjectPSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD_LAB.Controller
{
    public class UserController
    {
        public static List<User> GetUsers()
        {
            return UserHandler.GetUsers();
        }

        public static Boolean IsAlphanumeric(string password)
        {
            foreach (char c in password)
            {
                if ((c >= 'a' && c <= 'z') && (c >= 'A' && c <= 'Z') && (c >= '0' && c <= '9'))
                {
                    return true;
                }
            }
            return false;
        }
        public static string Register(string name, string email, string gender, string dob, string password, string role)
        {
            if(name == null || email == null || gender == null || dob == null || password == null)
            {
                return "All fields must be filled";
            }
            else if(name.Length < 5 || name.Length > 50)
            {
                return "Name must be between 5 to 50 characters";
            }
            else if(UserHandler.GetUser(name) != null)
            {
                return "Username already exists. Try another one";
            }
            else if (!IsAlphanumeric(password))
            {
                return "Password must be alphanumeric";
            }
            return "Password must be alphanumeric";
        }
    }
}