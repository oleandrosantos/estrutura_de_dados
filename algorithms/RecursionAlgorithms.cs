using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estrutura_de_dados.algorithms
{
  public static class RecursionAlgorithms
  {
    public static void CountDownWithRecursion(int n)
    {
      //Caso base
      if (n <= 0)
      {
        Console.WriteLine("End Counter");
        return;
      }
      //Recursão
      Console.WriteLine(n);
      CountDownWithRecursion(n - 1);
    }

    public static int PrintFactorials(int n)
    {
      if (n <= 1) return 1;
      return n * PrintFactorials(n - 1);
    }
  }
}