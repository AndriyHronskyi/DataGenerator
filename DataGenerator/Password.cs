using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataGenerator
{
    public class Password : TypeData
    {
        Random random = new Random();
        static List<string> passwords = new List<string>();
        public override void Generate()
        {
            Thread.Sleep(10);
            var prePass = random.Next(10000, 999999).ToString();

            if (prePass.Equals(passwords))
            {
                Thread.Sleep(30);
                Generate();
            }
            else
            {
                passwords.Add(prePass);
            }
        }

        Password()
        {
            Generate();
        } 

    }
}
