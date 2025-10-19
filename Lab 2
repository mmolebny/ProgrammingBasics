using System;
using System.Collections.Generic;

namespace Lab_2
{
  internal class Program
  {
    static void Greet(string name)
    {
      Console.WriteLine($"Привіт, {name}!\n");
    }

    static int[] Range(int start, int end)
    {
      int size = end - start + 1;
      int[] result = new int[size];
      Console.WriteLine("Range (всі числа від start до end):");
      for (int i = 0; i < size; i++)
      {
        result[i] = start + i;
        Console.Write(result[i] + " ");
      }
      Console.WriteLine("\n");
      return result;
    }

    static int[] rangeOdd(int startOdd, int endOdd)
    {
      int count = 0;
      for (int i = startOdd; i <= endOdd; i++)
        if (i % 2 != 0) count++;

      int[] resultOdd = new int[count];
      int index = 0;
      Console.WriteLine("RangeOdd (всі непарні числа від start до end):");
      for (int i = startOdd; i <= endOdd; i++)
      {
        if (i % 2 != 0)
        {
          resultOdd[index] = i;
          Console.Write(resultOdd[index] + " ");
          index++;
        }
      }
      Console.WriteLine("\n");
      return resultOdd;
    }

    static double Average(double x, double y)
    {
      double average = (x + y) / 2;
      Console.WriteLine($"Average({x}, {y}) = {average}");
      return average;
    }

    static double Square(double x)
    {
      double square = x * x;
      Console.WriteLine($"Square({x}) = {square}");
      return square;
    }

    static double Cube(double x)
    {
      double cube = x * x * x;
      Console.WriteLine($"Cube({x}) = {cube}");
      return cube;
    }

    static double[] Calculate()
    {
      double[] results = new double[10];
      Console.WriteLine("\nCalculate (середнє квадрату і кубу від 0 до 9):");
      for (int i = 0; i < 10; i++)
      {
        results[i] = Average(Square(i), Cube(i));
      }
      Console.WriteLine();
      return results;
    }

    static readonly Person obj1 = new Person { Name = "Alice" };
    static Person obj2 = new Person { Name = "Bob" };

    static void Fn()
    {
      Console.WriteLine("Об'єкти:");
      Console.WriteLine($"До зміни: obj1 = {obj1.Name}, obj2 = {obj2.Name}");
      obj1.Name = "Charlie";
      obj2.Name = "Diana";
      Console.WriteLine($"Після зміни поля: obj1 = {obj1.Name}, obj2 = {obj2.Name}");
      obj2 = new Person { Name = "Eve" };
      Console.WriteLine($"Після переназначення obj2: obj1 = {obj1.Name}, obj2 = {obj2.Name}\n");

      var user = CreateUser("Marcus Aurelius", "Roma");
      Console.WriteLine("Створений користувач:");
      Console.WriteLine($"Ім'я: {user["name"]}, Місто: {user["city"]}\n");

      CollectionsDemo();
    }

    static Dictionary<string, string> CreateUser(string name, string city)
    {
      return new Dictionary<string, string> { { "name", name }, { "city", city } };
    }

    static void CollectionsDemo()
    {
      List<Dictionary<string, string>> phoneBook = new List<Dictionary<string, string>>()
            {
                new Dictionary<string,string> { { "name", "Marcus Aurelius" }, { "phone", "+380445554433" } },
                new Dictionary<string,string> { { "name", "Julia" }, { "phone", "+380501112233" } },
                new Dictionary<string,string> { { "name", "Max" }, { "phone", "+380631234567" } }
            };

      Console.WriteLine("Телефонна книга:");
      foreach (var entry in phoneBook)
        Console.WriteLine($"{entry["name"]}: {entry["phone"]}");
      Console.WriteLine();

      Dictionary<string, string> phoneHash = new Dictionary<string, string>();
      foreach (var entry in phoneBook)
        phoneHash[entry["name"]] = entry["phone"];

      Console.WriteLine("Пошук по імені (Hash):");
      Console.WriteLine("Julia: " + (phoneHash.ContainsKey("Julia") ? phoneHash["Julia"] : "Не знайдено"));
      Console.WriteLine("Max: " + (phoneHash.ContainsKey("Max") ? phoneHash["Max"] : "Не знайдено"));
      Console.WriteLine();
    }

    static void Main(string[] args)
    {
      string name = "Max";
      int age = 17;

      Console.WriteLine("=== Початок програми ===\n");

      Greet(name);
      Range(15, 30);
      rangeOdd(15, 30);
      Average(2, 20);
      Square(2);
      Cube(2);
      Calculate();
      Fn();

    }
  }

  class Person
  {
    public string Name;
  }
}

