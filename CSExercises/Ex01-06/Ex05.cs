using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input you No");
            Double No = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:0.000}", Math.Sqrt(No));
        }
    }
}
