using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your distance");
            Double X = Convert.ToDouble(Console.ReadLine());
            Double Y = 2.40 + X * 0.4;
            Console.WriteLine(Y);
        }
    }
}
