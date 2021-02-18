using System;

namespace QuickSort
{
  public class QuickSort
  {    
    public static int[] QSort(int[] arr, int left, int right)
    {
      if (left < right)
      {
        int position = Partition(arr, left, right);
        QSort(arr, left, position - 1);
        QSort(arr, position + 1, right);
      }
      return arr;
    }
    static int Partition(int[] arr, int left, int right)
    {
      int pivot = arr[right];
      int low = left - 1;

      for (int i = left; i <= right; i++)
      {
        if (arr[i] < pivot)
        {
          low++;
          arr = Swap(arr, i, low);
        }
      }
      arr = Swap(arr, right, low + 1);
      return low + 1;
    }
    static int[] Swap(int[] arr, int i, int low)
    {
      int temp = arr[i];
      arr[i] = arr[low];
      arr[low] = temp;
      return arr;
    }

  }
}
