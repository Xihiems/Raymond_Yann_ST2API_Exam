using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raymond_Yann_ST2API_Exam
{
    internal class PaperScissor
    {

        public void Play() 
        {
            List<string> list = new List<string>() { "rock","paper","scissor" };

            int scoreuser = 0;
            int scorecomputer = 0;

            while (scoreuser != 3 && scorecomputer != 3) 
            {
                var random = new Random();
                int index = random.Next(list.Count);
                string inputcomputer = list[index];

                //user choice

                Console.WriteLine("Please write your answer (Rock,Paper or scissor)");
                string inputuser = Console.ReadLine().ToLower();
                while (inputuser != "rock" && inputuser != "paper" && inputuser != "scissor")
                {
                    Console.WriteLine("Please write a correct answer");
                    Console.WriteLine("Rock;Paper;scissor");
                    Console.WriteLine("Please write your answer (Rock,Paper or scissor)");
                    inputuser = Console.ReadLine().ToLower();

                }
                Console.WriteLine(inputcomputer);
                
                if (inputuser == "rock")
                {
                    if (inputcomputer == "paper")
                    {
                        scorecomputer += 1;
                    }
                    else if (inputcomputer == "scissor")
                    {
                        scoreuser += 1;
                    }
                    else { }
                }
                else if (inputuser == "paper")
                {
                    if (inputcomputer == "scissor")
                    {
                        scorecomputer += 1;
                    }
                    else if (inputcomputer == "rock")
                    {
                        scoreuser += 1;
                    }
                    else { }
                }
                else
                {
                    if (inputcomputer == "rock")
                    {
                        scorecomputer += 1;
                    }
                    else if (inputcomputer == "paper")
                    {
                        scoreuser += 1;
                    }
                    else { }
                }
                Console.WriteLine("Your score :" + scoreuser.ToString());
                Console.WriteLine("Computer score :" + scorecomputer.ToString());

            }

            if (scoreuser == 3)
            {
                Console.WriteLine("You Win");
            }
            else 
            {
                Console.WriteLine("You Lose");
            }

        }

        
    }
}
