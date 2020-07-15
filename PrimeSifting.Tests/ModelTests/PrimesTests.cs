using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimesTests
  {
    [TestMethod]
    public void PrimesConstructor_CreatesInstanceOfItem_Item()
    {
      Primes testPrimes = new Primes();
      Assert.AreEqual(typeof(Primes), testPrimes.GetType());
    }
  }
}