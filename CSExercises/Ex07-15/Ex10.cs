using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your X1");
            Double X1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input your Y1");
            Double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input your X2");
            Double X2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input your Y2");
            Double Y2 = Convert.ToDouble(Console.ReadLine());
            Double x = Math.Pow(X2 - X1, 2);
            Double y = Math.Pow(Y2 - Y1, 2);
            Double d = x + y;
            Double D = Math.Sqrt(d);
            Console.WriteLine(D);
        }
    }
}
