
using System;
using System.Collections.Generic;


class Num
{
  public int n;
  public Num(int n)
  {
    this.n = n;
  }
}
class Program
{
  static int Inc(int n)
  {
    return n + 1;
  }


  static void Inc(Num num)
  {
    num.n += 1;
  }

  static void Main()
  {

    int a = 5;
    int b = Inc(a);
    Console.WriteLine($"Приклад 1 - inc(n: number): number");
    Console.WriteLine($"a = {a}, b = {b}\n");


    Num obj = new Num(1) { n = 5 };
    Inc(obj);
    Console.WriteLine($"Приклад 2 - inc(num: Num)");
    Console.WriteLine($"obj.n = {obj.n}\n");

    object[] value = {
    true, "hello", 5, 12.5, -200, false, true, "word",
    'A', null, new int[] { 1, 2 },
    3.14f, 42L, 100m, new DateTime(2023, 1, 1), new Num (1)};

    var TypeCount = new Dictionary<string, int>
    {
            { "number", 0 },
            { "string", 0 },
            { "boolean", 0 },
            { "char", 0 },
            { "array", 0 },
            { "null", 0 },
            { "date", 0 },
            { "object", 0 },
            { "other", 0 }
    };

    foreach (var item in value)
    {
      string type;

      if (item == null)
        type = "null";
      else if (item is int || item is double || item is float || item is long || item is decimal)
        type = "number";
      else if (item is string)
        type = "string";
      else if (item is bool)
        type = "boolean";
      else if (item is char)
        type = "char";
      else if (item is Array)
        type = "array";
      else if (item is DateTime)
        type = "date";
      else if (item is object)
        type = "object";
      else
        type = "other";

      TypeCount[type]++;
    }


    foreach (var pair in TypeCount)
    {
      Console.WriteLine($"{pair.Key}: {pair.Value}");
    }
  }
}
