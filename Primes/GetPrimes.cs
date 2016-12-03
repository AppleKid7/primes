using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class GetPrimes
    {
        public List<int> getPrimes(int n) {
            List<int> primes = new List<int>();
            while (n % 2 == 0)
            {
                primes.Add(2);
                n /= 2;
            }
            for(int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while(n % i == 0)
                {
                    primes.Add(i);
                    n /= i;
                }
            }
            if(n > 2)
            {
                primes.Add(n);
            }
            return primes;
        }
    }
}
