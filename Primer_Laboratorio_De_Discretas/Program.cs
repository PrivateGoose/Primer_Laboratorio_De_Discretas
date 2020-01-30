using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Primer_Laboratorio_De_Discretas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey holmes!, introduce a number and let´s get into it!");  /*Greeting message from a friendly cholo*/
            string input = Console.ReadLine();
            BigInteger a = int.Parse(input);
            /*a is the number that the user introduces, it symbolizes the position in the succession*/
            BigInteger integer = a - 1;
            /*This is for fixing the position of the position*/

            List<BigInteger> pentagonal = new List<BigInteger>();
            List<BigInteger> fibonacci = new List<BigInteger>() { 0, 1 };
            /*Lists for the successions*/
            
            for (BigInteger n =1; n < (a + 1); n++)
            {
                BigInteger penta = (n * ((3 * n) - 1)) / 2;
                pentagonal.Add(penta);
            }
            /*This is the formula for the pentagonal succession*/

            for (BigInteger y = 1; y < a - 1; y++) 
            {
                var fibo = (fibonacci[fibonacci.Count - 1]) + (fibonacci[fibonacci.Count - 2]);
                fibonacci.Add(fibo);
            }
            /* a-1 is used because there are already two initial elements in the fibonacci list, and we need the number of elements that are introduced on "a" plus 1 from the for*/

            BigInteger penta_acum = 0;
            foreach ( BigInteger p in pentagonal)
            {
                penta_acum += p; 
            }
            /*This is the pattern of the succession and it shows how they accumulate to give the desired result*/

            BigInteger fibo_acum = 0;
            foreach (BigInteger f in fibonacci)
            {
                fibo_acum += f; 
            }
            /*Same thing from above*/

            BigInteger product = penta_acum * fibo_acum;
            Console.WriteLine(product);
            /*Final consolidation of the steps taken in the process*/
        }
    }
}
