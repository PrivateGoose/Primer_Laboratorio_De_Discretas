using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Laboratorio_De_Discretas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey holmes!, introduce a number and let´s get into it!");
            string input = Console.ReadLine();
            int a = int.Parse(input);
            /*a is the number that the user introduces, it symbolizes the position in the succession*/
            int integer = a - 1;

            List<int> pentagonal = new List<int>();
            List<int> fibonacci = new List<int>() { 0, 1 };
            
            for (int n =1; n < (a + 1); n++)
            {
                int penta = (n * ((3 * n) - 1)) / 2;
                pentagonal.Add(penta);
            }

            for (int y = 1; y < a - 1; y++) /* a-1 is used because there are already two initial elements in the fibonacci list, and we need the number of elements that are introduced on "a" plus 1 from the for*/
            {
                var fibo = (fibonacci[fibonacci.Count - 1]) + (fibonacci[fibonacci.Count - 2]);
                fibonacci.Add(fibo);
            }

            int penta_acum = 0;
            foreach ( int p in pentagonal)
            {
                penta_acum += p; 
            }

            int fibo_acum = 0;
            foreach (int f in fibonacci)
            {
                fibo_acum += f; 
            }

            int product = penta_acum * fibo_acum;
            Console.WriteLine(product);
        }
    }
}
