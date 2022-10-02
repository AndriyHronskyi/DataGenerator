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

        Password()
        {
            Generate();
        }

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

        private string GenerateOneNum()
        {
            Thread.Sleep(15);

            return random.Next(0, 9).ToString();
        }

        private string GenerateOneLetter()
        {
            //get it from some array string[] of Letters. Letters[] = {"a", "b", "c"...}

            //change
            return random.Next(0, 9).ToString();
        }

        private string GenerateOneSymbol()
        {
            //get it from some array string[] of Symbols

            string[] Symbols = new string[] { "%", "$", "@", "&"};
            string result = Symbols[random.Next(0, Symbols.Length - 1)];
            
            return result;
        }



        //Add another constructor with input parameters, which gives feature to create not only numeric password 
        /*
         * int minPassLength = 5;                                      // it can be a input value
         * int maxPassLength = minPassLength + 5;
         * 
         * int pasLength = random.Next(minPassLength,maxPassLength);   //where 5 - min password length
         * 
         * 
         * 
         * switch(input_param){
         * case letters:
         *      1) int numbOfLettersInsertsInPassword = random.Next(2,6);    // max value can be "minPassLength - 1"
         *      2) int 
         *      2) int[] positionOfInsertLetter = new int[numbOfLettersInsertsInPassword]();   //array with positions of letters in password
         *          for(int i = 0; i < numbOfLettersInsertsInPassword; i++)
         *          {
         *              int buff = 0;
         *              do{
         *                  buff = random.Next(2, pasLength - 1);
         *                  
         *                  //перевірка чи нова позиція не співпадає з іншою позицією
         *              }while(positionOfInsertLetter.Compare(buff) == 1)
         *              
         *              positionOfInsertLetter[i] = buff;
         *          }
         *      3) 
         *      
         *      
         *      
         *      
         *         foreach(int pos in positionOfLetters)
         *     break;
         * }
         * 
         * or
         *      string[] pass = new string[pasLength]();
         *      
         *      for(int i = 0; i < pasLength; i++)
         *      {
         *          if(random.Next(1,3) == 1)
         *          {
         *              switch(random.Next(0,2))
         *              {
         *                  case 0:
         *                      //Letters
         *                      pass[i] = GenerateOneLetter();   //get it from some array string[] of Letters. Letters[] = {"a", "b", "c"...}
         *                  break;
         *                  case 1:
         *                      //Upper letter
         *                      pass[i] = GenerateOneLetter().ToUpper;
         *                  break;
         *                  case 2:
         *                      //Symbols
         *                      pass[i] = GenerateOneSymbol();
         *                  break;
         *              }
         *          }
         *          else
         *          {
         *              pass[i] = GenerateOneNum();
         *          }
         *          
         *      }
         * 
         * **/

    }
}
