using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your number");
            Double x = Convert.ToDouble(Console.ReadLine());
            Double y =2*Math.Pow(x,2)-4*x+3;
            Console.WriteLine(y);
        }
    }
}
