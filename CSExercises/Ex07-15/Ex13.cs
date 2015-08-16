using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your distance");
            Double X = Convert.ToDouble(Console.ReadLine());
            Double Y = 2.40 + X * 0.4;
            Double N = Math.Round(Y, 1);
            if (Y <= N)
            { Console.WriteLine("{0:0.00}" ,N);
                } 
            else
            {
                Console.WriteLine("{0:0.00}", N + 0.1);
            }
        }
    }
}
