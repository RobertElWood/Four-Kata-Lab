using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLab
{
    public class OddEvenKata
    {

        public List<int> Primes { get; set; } = new List<int>();


        public OddEvenKata()
        {
            PrimesSieve(100);
        }

        //Creates a list of all integers from 1 to 100, recording whether they are odd or even.
        public List <string> OddOrEvens()
        {
            List<string> output = new List<string>();

            for (int i = 1; i < 101; i++)
            {
                if (Primes.Contains(i) == true)
                {
                    output.Add("PRIME");
                }
                else if (i % 2 == 0)
                {
                    output.Add("EVEN");
                }
                else
                {
                    output.Add("ODD");
                }
            }

            return output;
 
        }

        //Sieve of Eratosthenes method to find primes up to 100
        public void PrimesSieve(int maxNum)
        {
            bool[] primes = new bool[maxNum + 1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            for(int i=2; i<Math.Sqrt(maxNum); i++)
            {
                if (primes[i-1])
                {
                    for (int j = (int)Math.Pow(i, 2); j <= maxNum; j += i)
                    {
                        primes[j - 1] = false;
                    }
                }
            }

            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i - 1])
                {
                    Primes.Add(i);
                }
            }
        }

        //Method to print output of OddOrEvens() method.
        public void PrintList(List<string> output)
        {
            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine($"{i+1}) {i+1} is {output[i]}");
            }
        }
    }
}
