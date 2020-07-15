using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting;
using System.Collections.Generic;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimesTests
  {
    [TestMethod]
    public void PrimesConstructor_CreatesInstanceOfPrime_Prime()
    {
      Primes testPrimes = new Primes();
      Assert.AreEqual(typeof(Primes), testPrimes.GetType());
    }

    [TestMethod]
    public void CreateList_CreatesListOfNums_List()
    {
      Primes testPrimes = new Primes();
      List<int> newList = new List<int> { 2, 3, 4 };
      List<int> result = testPrimes.CreateList(5);
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ReturnPrimes_ReturnsPrimeList_List()
    {
      Primes testPrimes = new Primes();
      List<int> newList = new List<int> { 2, 3};
      List<int> result = testPrimes.CreateList(5);
      CollectionAssert.AreEqual(newList, testPrimes.ReturnPrimes(result)); 
    }
  }
}