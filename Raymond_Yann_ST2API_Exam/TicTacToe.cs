using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raymond_Yann_ST2API_Exam
{
    internal class TicTacToe
    {
        private List<string> arr = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public void Play()
        {
            Console.Clear();
            Console.WriteLine("Player : O and computer : X");
            Board();
            Console.WriteLine("Choose a place to write O");
            int choice = int.Parse(Console.ReadLine());//Taking users choice
                                                       // checking that position where user want to run is marked (with X or O) or not
            if (arr[choice-1] != "X" && arr[choice-1] != "O")
            {
                arr[choice-1] = "O";

            }
            int flag = CheckWin();
            while (flag != 1 && flag != -1) {
            // This loop will be run until all cell of the grid is not marked
            //with X and O or some player is not win
            Console.Clear();// clearing the console
            Board();// getting filled board again
                if (flag == 1)
                // if flag value is 1 then someone has win or
                //means who played marked last time which has win
                {
                    Console.WriteLine("Player has won");
                }
                else if (flag == -1)// if flag value is -1 the match will be draw and no one is winner
                {
                    Console.WriteLine("Draw");
                }
                else 
                {
                    int computerchoose = Computerchoose();
                    if (arr[computerchoose] != "X" && arr[computerchoose] != "O")
                    {
                        arr[computerchoose] = "X";

                    }
                    Board();
                    Console.WriteLine("Choose a place to write O");
                    choice = int.Parse(Console.ReadLine());//Taking users choice
                                                               // checking that position where user want to run is marked (with X or O) or not
                    if (arr[choice-1] != "X" && arr[choice-1] != "O")
                    {
                        arr[choice-1] = "O";

                    }
                    flag = CheckWin();
                }

                if (flag == 1) 
                {
                    Console.WriteLine("Player has win");
                }
                if (flag == -1) 
                {
                    Console.WriteLine("Drawn");
                }
            }

        }

        private void Board()
        {
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[0], arr[1], arr[2]);

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[3], arr[4], arr[5]);

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[6], arr[7], arr[8]);
        }

        private int Computerchoose()
        {
            List<string> possibleanswer = new List<string>();
            foreach (var items in arr)
            {
                Console.WriteLine(items);
                if (items != "X"&&items!="O")
                {
                   Console.WriteLine("Je suis la");
                   possibleanswer.Add(items);
                    
                }
            }
            var random = new Random();
            int index = random.Next(possibleanswer.Count);
            string choicecomputer = possibleanswer[index];
            int indexchoicecomputer = possibleanswer.FindIndex(a => a.Contains(choicecomputer));
            return indexchoicecomputer;
        }
        private int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (arr[0] == arr[1] && arr[1] == arr[2])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (arr[3] == arr[4] && arr[4] == arr[5])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (arr[5] == arr[6] && arr[6] == arr[7])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (arr[0] == arr[3] && arr[3] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[0] == arr[4] && arr[4] == arr[8])
            {
                return 1;
            }
            else if (arr[2] == arr[4] && arr[4] == arr[6])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (arr[0] != "1" && arr[1] != "2" && arr[2] != "3" && arr[3] != "4" && arr[4] != "5" && arr[5] != "6" && arr[6] != "7" && arr[7] != "8" && arr[8] != "9")
            {
                return -1;
            }
            #endregion
            else 
            {
                return 0;
            }
        }
    }
}
