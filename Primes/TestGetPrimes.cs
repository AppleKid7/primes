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
            List<int> expected = new List<int>();
            expected.Add(5);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void testGetPrimesLarge()
        {
            GetPrimes primes = new Primes.GetPrimes();
            List<int> result = primes.getPrimes(315);
            List<int> expected = new List<int>();
            expected.Add(3);
            expected.Add(3);
            expected.Add(5);
            expected.Add(7);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void testGetPrimesLargeDouble()
        {
            GetPrimes primes = new Primes.GetPrimes();
            List<int> result = primes.getPrimes(630);
            List<int> expected = new List<int>();
            expected.Add(2);
            expected.Add(3);
            expected.Add(3);
            expected.Add(5);
            expected.Add(7);
            Assert.AreEqual(expected, result);
        }
    }
}
