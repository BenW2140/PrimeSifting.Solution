using System;
using System.Collections.Generic;
using PrimeSifting;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a number to get all primes below that number: ");
    int number = int.Parse(Console.ReadLine());
    Primes primeList = new Primes();
    List<int> numList = primeList.CreateList(number);
    numList = primeList.ReturnPrimes(numList);
    foreach (int num in numList)
    {
      Console.WriteLine(num);
    }
  }
}