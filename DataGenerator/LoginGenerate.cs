using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    public class LoginGenerate
    {
        private Random random = new Random(); 
        private string username { get; set; }
        private string Login 
        {
            get { return Login; }
            set { Login = username + random.Next(111, 999).ToString(); } 
        }
        private string Email { get; set; }

        private string[] EmailDomains = {"@mail.ua",
                                         "@gmail.com",
                                         "@outlook.com",
                                         "@ukr.net",
                                         "@hotmail.com",
                                         "@list.ua"};

        public LoginGenerate() { }

        public string GetUsername(char[] name)
        {
            return name.ToString();
        }

        public string GetEmail()
        {
            Email = Login + EmailDomains[random.Next(0, 5)];
            return Email;
        }

        public string GetPassword()
        {
            return random.Next(10000, 99999).ToString();
        }
    }
}
