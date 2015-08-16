using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a temperature in Centigrade");
            Double C = Convert.ToDouble(Console.ReadLine());
            Double F = 1.8 * C + 32;
            Console.WriteLine("The Fahrenheit temperature is " + F);
        }
    }
}
