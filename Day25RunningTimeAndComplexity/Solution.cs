using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Task
//A prime is a natural number greater than that has no positive divisors other than 
//    1 and itself.Given a number,n , determine and print whether it's  Prime or Not Prime.


//Note: If possible, try to come up with a primality algorithm, 
//    or see what sort of optimizations you come up with for an algorithm.
//    Be sure to check out the Editorial after submitting your code!

 //NOTES TO SELF
 //eliminate all even numbers except 2 (special case)
 //only check up to square root of number
namespace Day25RunningTimeAndComplexity
{
    class Solution
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41,
                43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113,
                127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199 };

            List<int> primes2 = new List<int> {  1, 4, 9, 16, 25, 36, 49, 64, 81, 100, 121,
                144, 169, 196, 225, 256, 289, 324, 361, 400, 441, 484, 529, 576, 625, 676,
                729, 784, 841, 907 };

            List<int> primes3 = new List<int> {16 };

            foreach (int i in primes)
            {
                IsPrime(i);
            }
            Console.ReadLine();
        }

        static void IsPrime(int num)
        {
            //iterate through the divisors 
            //we can exclude 1 
            //also we only need to check the first half od the divisors
            if(num == 2 || num == 3)
            {
                Console.WriteLine("Prime");
                return;
            }
            if(num == 1 || num <= 0 || num == 4)
            {
                Console.WriteLine("Not Prime");
                return;
            }
            if(num % 2 == 0)
            {
                Console.WriteLine("Not Prime");
                return;
            }

            
            //&& i%2 != 0
            for (int i = 3; (i * i) <= num; i+=2)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    return;
                }
            }

            Console.WriteLine("Prime");
        }
    }
}
