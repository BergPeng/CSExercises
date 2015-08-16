using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your a");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input your b");
            Double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input your c");
            Double c = Convert.ToDouble(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (b + c > a) && (a - c < b) && (a - b < c) && (b - c < a))
            {
                Double s = (a + b + c) / 2;
                Double S = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine(S);
            }
           else
            {
                Console.WriteLine("a, b and c are not three sides of a triangle");
            }
        }
    }
}