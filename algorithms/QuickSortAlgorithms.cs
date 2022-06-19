using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estrutura_de_dados.algorithms
{
  public static class QuickSortAlgorithms
  {
    public static int Sum(IEnumerable<int> arrayNumber)
    {
      var total = 0;
      foreach (var number in arrayNumber)
      {
        total += number;
      }
      return total;
    }

    public static int RecursionSum(IEnumerable<int> arrayNumber)
    {
      if (!arrayNumber.Any())
        return 0;

      return arrayNumber.First() + RecursionSum(arrayNumber.Skip(1));
    }

    public static int RecursionCount(IEnumerable<int> arrayNumber)
    {
      if (!arrayNumber.Any())
        return 0;

      return RecursionCount(arrayNumber.Skip(1)) + 1;
    }

    // Usando Switch
    public static int RecursionMax(IEnumerable<int> arrayNumber)
    {
      switch (arrayNumber.Count())
      {
        case 0: throw new ArgumentException(nameof(arrayNumber)); ;
        case 1: return arrayNumber.First();
        case 2:
          return arrayNumber.First() > arrayNumber.Last() ? arrayNumber.First() : arrayNumber.Last();
        default:
          var maiorvalor = RecursionMax(arrayNumber.Skip(1));
          return maiorvalor > arrayNumber.First() ? maiorvalor : arrayNumber.First();
      }
    }
    // Usando ifs
    public static int MaxValue(IEnumerable<int> list)
    {
      if (!list.Any())
        throw new ArgumentException(nameof(list));
      else if (list.Count() == 1)
        return list.First();
      else if (list.Count() == 2)
        return list.First() > list.Last() ? list.First() : list.Last();

      int maiorValor = MaxValue(list.Skip(1));
      return maiorValor > list.First() ? maiorValor : list.First();
    }
  }
}