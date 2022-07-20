using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raymond_Yann_ST2API_Exam
{
    internal class MoreLess
    {
        public void Play() 
        {
            //computer choose a number

            Random rd = new Random();
            int inputcomputer = rd.Next(0, 100);

            int inputuser;
            Console.WriteLine("Choose a number");
            while (int.TryParse(Console.ReadLine(), out inputuser) == false)
            {
                Console.WriteLine("Choose a correct number");
            }

            int numberanswer = 1;
            while (inputuser != inputcomputer) 
            {

                if (inputuser < inputcomputer)
                {
                    Console.WriteLine("Your number is lower to the computer");
                }
                else if (inputuser > inputcomputer) 
                {
                    Console.WriteLine("Your number is greater to the computer");

                }
                Console.WriteLine("Choose a number");
                while (int.TryParse(Console.ReadLine(), out inputuser) == false)
                {
                    Console.WriteLine("Choose a correct number");
                }
                numberanswer += 1;
            }
            Console.WriteLine($"You have found in {numberanswer} tries ");
        }
    }
}
