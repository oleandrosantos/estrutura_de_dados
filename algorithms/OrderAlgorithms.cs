using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algorithms
{
  public static class OrderAlgorithms
  {
    public static int[] SelectionSort(List<int> arr)
    {
      var newArr = new int[arr.Count];
      for (int i = 0; i < newArr.Length; i++)
      {
        var indexSmallest = FindIndexSmallest(arr);
        newArr[i] = arr[indexSmallest];
        arr.RemoveAt(indexSmallest);
      }
      return newArr;
    }

    private static int FindIndexSmallest(List<int> arr)
    {
      var smallest = arr[0];
      var smallestIndex = 0;
      for (int i = 0; i < arr.Count; i++)
      {
        if (arr[i] < smallest)
        {
          smallest = arr[i];
          smallestIndex = i;
        }
      }
      return smallestIndex;
    }

  }
}
