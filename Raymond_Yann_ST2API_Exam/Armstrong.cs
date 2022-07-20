using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raymond_Yann_ST2API_Exam
{
    internal class Armstrong
    {
        public void getArmstrongnumber()
        {
            for (int i = 100; i < 1000; i++)
            {
                int j = i;
                double sum = 0;
                while (j > 0)
                {
                    int number = j % 10;
                    sum += Math.Pow(number, 3);
                    j = j / 10;

                }
                if (i == (int)sum)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
