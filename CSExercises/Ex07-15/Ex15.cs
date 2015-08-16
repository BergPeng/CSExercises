using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your number");
            int A = Convert.ToInt32(Console.ReadLine());
            double N = A / 100;
            int a = Convert.ToInt32(Math.Floor(N));
            double M = (A - 100 * a) / 10;
            int b= Convert.ToInt32(Math.Floor(M));
            int c = A - a * 100 - b * 10;
            int Q = Convert.ToInt32(Math.Pow(a, 3));
            int W = Convert.ToInt32(Math.Pow(b, 3));
            int E = Convert.ToInt32(Math.Pow(c, 3));
            int Y = Q + W + E;
            bool R = Convert.ToBoolean(Y);
            bool T = Convert.ToBoolean(A);
            if (R = T)
            {
                Console.WriteLine("A is an Armstrong number");
            }
            else
            {
                Console.WriteLine("A is not an Armstrong number");
            }

        }
    }
}
