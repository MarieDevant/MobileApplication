﻿using System;
namespace MobileApp.Model
{
    public class User
    {
        private string name;
        private string password;

        public User(string n, string pw)
        {
            name = n;
            password = pw;
        }

        public string Name{
            get{
                return name;
            }
            set{
                name = value;
            }
        }
        public string Password{
            get{
                return password;
            }
            set{
                password = value;
            }
        }
    }
}
