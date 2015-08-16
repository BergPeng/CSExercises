using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Double A , B , C;
            Console.WriteLine("Input you salary");
            A = Convert.ToDouble(Console.ReadLine());
            B = A * 0.1 ;
            C = A * 0.03;
            Console.WriteLine("Your total income" +( A + B + C));
        }
    }
}
