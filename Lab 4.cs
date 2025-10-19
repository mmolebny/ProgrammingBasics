using System;
using System.Collections.Generic;


internal class Program
{
  // перший спосіб через foreach
  static int Sum(params int[] numbers)
  {
    int total = 0;
    foreach (var n in numbers)
    {
      total += n;
    }
    Console.WriteLine("Method 1 = " + total);
    return total;
  }

  // другий спосіб через for
  static int Sum1(params int[] numbers)
  {
    int total = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
      total += numbers[i];
    }
    Console.WriteLine("Method 2 = " + total);

    return total;
  }

  // третій спосіб через while
  static int Sum2(params int[] numbers)
  {
    int total = 0;
    int i = 0;
    while (i < numbers.Length)
    {
      total += numbers[i];
      i++;
    }
    Console.WriteLine("Method 3 = " + total);
    return total;
  }

  // четвертий спосіб через do...while
  static int Sum3(params int[] numbers)
  {
    int total = 0;
    int i = 0;
    do
    {
      total += numbers[i];
      i++;
    }
    while (i < numbers.Length);
    Console.WriteLine("Method 4 = " + total + "\n");
    return total;
  }

  //п'ятий спосіб - метод Array.prototype.reduce()
  static int Reduce(int[] numbers, int initial, Func<int, int, int> operation)
  {
    int result = initial;
    for (int i = 0; i < numbers.Length; i++)
    {
      result = operation(result, numbers[i]);
    }
    return result;
  }


  //генерація випадкових чисел для заповнення ними двохвимірного масиву
  static Random rand = new Random();
  static int RandomNumber(int min, int max)
  {
    return rand.Next(min, max);
  }

  static void CollectionsDemo()
  {
    List<Dictionary<string, string>> persons = new List<Dictionary<string, string>>
    {
      new Dictionary<string, string> { { "name", "Mao" }, { "born", "1893" }, { "died", "1976" } },
      new Dictionary<string, string> { { "name", "Gandhi" }, { "born", "1869" }, { "died", "1948" } }
    };

    foreach (var person in persons)
    {
      int born = int.Parse(person["born"]);
      int died = int.Parse(person["died"]);
      int lifespan = died - born;
      Console.WriteLine($"{person["name"]} прожив {lifespan} лет");
    }
  }


  static void Main()
  {
    Sum(new int[] { 1, 2 });
    Sum1(new int[] { 1, 2 });
    Sum2(new int[] { 1, 2, 4 });
    Sum3(new int[] { 1, 3 });

    int rows = 3;
    int cols = 4;
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < cols; j++)
      {
        array[i, j] = rand.Next(1, 50);
        Console.Write(array[i, j] + "\t");
      }
      Console.WriteLine();
    }

    int max = array[0, 0];
    for (int f = 0; f < rows; f++)
      for (int g = 0; g < cols; g++)
        if (array[f, g] > max)
          max = array[f, g];
    Console.WriteLine("Максимальний елемент масиву = " + max);

    int[] nums = { 1, 2, 3, 4, 5 };
    int sum = Reduce(nums, 0, (acc, x) => acc + x);
    Console.WriteLine("Сума через Reduce: " + sum + "\n");
    CollectionsDemo();

  }
    
  }
