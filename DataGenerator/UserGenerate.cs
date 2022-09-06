﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    public class UserGenerate
    {
        private Random random = new Random();
        private string username;
        public string login { get { return username + random.Next(111, 999).ToString(); }}
        public string email { get { return login + EmailDomains[random.Next(0, 5)]; ; } }

        private string[] EmailDomains = {"@mail.ua",
                                         "@gmail.com",
                                         "@outlook.com",
                                         "@ukr.net",
                                         "@hotmail.com",
                                         "@list.ua"};

        public UserGenerate() { }

        public void SetUsername(string name, string lastName)
        {
            //.Trim()
            //username = name.ToString();   /// Переробити

            name.Trim();
            lastName.Trim();
            /*lastName.Remove(random.Next(3,5),lastName.Count);
            lastName.CopyTo()*/
            username = name + lastName;
        }

        public string GetPassword()
        {
            return random.Next(10000, 99999).ToString();
        }

        public string GetDate()
        {
            RandomDate RandDate = new RandomDate();
            return RandDate.GetRandomDate();
        }
    }
}