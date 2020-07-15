using System;
using System.Collections.Generic;

namespace PrimeSifting
{
  public class Primes
  {
    public List<int> CreateList(int num)
    {
      List<int> intList = new List<int> {};
      for (int i = 2; i < num; i++)
      {
        intList.Add(i);
      }
      return intList;
    }

    public List<int> ReturnPrimes(List<int> intList)
    {
      for(int i = 0; i < intList.Count; i++ )
      {
        for (int j = i + 1; j < intList.Count; j++)
        {
          if(intList[j] % intList[i] == 0)
          {
            intList.RemoveAt(j);
          }
        }
      }
      return intList;
    }
  }
}