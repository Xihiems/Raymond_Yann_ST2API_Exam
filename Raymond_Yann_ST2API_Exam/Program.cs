using Raymond_Yann_ST2API_Exam;
using System;
using System.Linq;
namespace BlankExam2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Armstrong Number");
            Console.WriteLine("2.More or less");
            Console.WriteLine("3.Paper rock scissor");
            Console.WriteLine("4.Tic Tac Toe");
            Console.WriteLine("0.Quit");
            int inputuser;
            while (int.TryParse(Console.ReadLine(), out inputuser) == false)
            {
                Console.WriteLine("Choose a correct number");
            }
            while (inputuser != 0) 
            {
                if (inputuser == 1)
                {
                    Console.Clear();
                    Armstrong armstrong = new Armstrong();
                    armstrong.getArmstrongnumber();
                    
                }
                else if (inputuser == 2)
                {
                    Console.Clear();
                    MoreLess moreless = new MoreLess();
                    moreless.Play();
                }
                else if (inputuser == 3)
                {
                    Console.Clear();
                    PaperScissor paperScissor = new PaperScissor();
                    paperScissor.Play();
                }
                else if (inputuser == 4)
                {
                    Console.Clear();
                    TicTacToe tictactoe = new TicTacToe();
                    tictactoe.Play();
                }
                else 
                {
                    Console.WriteLine("Choose a correct number");
                }
                Console.WriteLine("1.Armstrong Number");
                Console.WriteLine("2.More or less");
                Console.WriteLine("3.Paper rock scissor");
                Console.WriteLine("4.Tic Tac Toe");
                Console.WriteLine("0.Quit");
                while (int.TryParse(Console.ReadLine(), out inputuser) == false)
                {
                    Console.WriteLine("Choose a correct number");
                }
            }

            
            
        }
    }
}
