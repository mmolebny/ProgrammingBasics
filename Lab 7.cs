using System;

class Program
{
  static void Main()
  {
    int[] arr = { 1, 2, 3, 4, 5, 6, 4, 7, 7 };
    int[] result = RemoveElement(arr);
    int[] result2 = Unique(arr);

    int[] array1 = { 7, -2, 10, 5, 0 };
    int[] array2 = { 0, 10 };
    int[] result3 = Difference(array1, array2);

    for (int i = 0; i < result.Length; i++)
    {
      Console.WriteLine(result[i] + " ");
    }
  }

  static int[] RemoveElement(int[] arr)
  {
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] != 4 && arr[i] != 7)
        count++;
    }

    int[] newArr = new int[count];
    int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] != 4 && arr[i] != 7)
      {
        newArr[j] = arr[i];
        j++;
      }
    }

    return newArr;
  }

  static int[] Unique(int[] arr)
  {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      if (i == 0 || arr[i] != arr[i - 1])
        count++;
    }

    int[] newArr = new int[count];
    int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {
      if (i == 0 || arr[i] != arr[i - 1])
      {
        newArr[j] = arr[i];
        j++;
      }
    }
    return newArr;
  }

  public static T[] Difference<T>(T[] array1, T[] array2)
  {
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
      bool found = false;
      for (int j = 0; j < array2.Length; j++)
      {
        if (object.Equals(array1[i], array2[j]))
        {
          found = true;
          break;
        }
      }
      if (!found)
      {
        count++;
      }
    }

    T[] result = new T[count];
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
      bool found = false;
      for (int j = 0; j < array2.Length; j++)
      {
        if (object.Equals(array1[i], array2[j]))
        {
          found = true;
          break;
        }
      }
      if (!found)
      {
        result[index] = array1[i];
        index++;
      }
    }

    return result;
  }
}
