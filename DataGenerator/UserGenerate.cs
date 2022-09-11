using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataGenerator
{
    public class UserGenerate
    {
        private Random random = new Random();
        private Random random2 = new Random();
        private Random random3 = new Random();

        private string username;
        public string login { get { return username + random.Next(111, 999).ToString(); }}
        public string email { get { return login + EmailDomains[random.Next(0, 5)]; } }

        private string[] EmailDomains = {"@mail.ua",
                                         "@gmail.com",
                                         "@outlook.com",
                                         "@ukr.net",
                                         "@hotmail.com",
                                         "@list.ua"};

        public string password = "";

        public UserGenerate() { }

        public void SetUsername(string name, string lastName)
        {
            name.Trim();
            lastName.Trim();

            char[] a  = new char[random2.Next(2, 4)];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = lastName.ElementAt(i);
            }

            string str = new string(a);

            username = name + str;
        }

        public void SetPassword()
        {
            Thread.Sleep(30);
            password = random3.Next(10000, 999999).ToString();
        }

        public string GetDate()
        {
            RandomDate RandDate = new RandomDate();
            return RandDate.GetRandomDate();
        }
    }
}
