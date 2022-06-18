using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algorithms
{
  public class OrderAlgorithms
  {
    public static int[] SelectionSort(List<int> arr)
    {
      var newArr = new int[arr.Count];
      for (int i = 0; i < newArr.Length; i++)
      {
        var smallest = FindSmallest(arr);
        newArr[i] = arr[smallest];
        arr.RemoveAt(smallest);
      }
      return newArr;
    }

    private static int FindSmallest(List<int> arr)
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