using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Primes
{
    [TestFixture]
    class TestGetPrimes
    {
        [Test]
        public void testGetPrimesSmall()
        {
            GetPrimes primes = new Primes.GetPrimes();
            List<int> result = primes.getPrimes(5);
            List<int> expected = new List<int> {5};
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void testGetPrimesLarge()
        {
            GetPrimes primes = new Primes.GetPrimes();
            List<int> result = primes.getPrimes(315);
            List<int> expected = new List<int> { 3, 3, 5, 7 };
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void testGetPrimesLargeDouble()
        {
            GetPrimes primes = new Primes.GetPrimes();
            List<int> result = primes.getPrimes(630);
            List<int> expected = new List<int> { 2, 3, 3, 5, 7 };
            Assert.AreEqual(expected, result);
        }
    }
}
