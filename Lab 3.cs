using System;

class Program
{
  static Random rnd = new Random();

  //випадкові числа від заданого min до max
  static int RandomNumber(int min, int max)
  {
    return rnd.Next(min, max + 1);
  }

  //випадкові числа для заданого min = 0
  static int RandomNumber(int max)
  {
    return rnd.Next(0, max + 1);
  }

  //генерація випадкових символів
  static string GenerateKey(int length, string characters)
  {
    string key = "";
    for (int i = 0; i < length; i++)
    {
      int index = rnd.Next(0, characters.Length);
      key += characters[index];
    }
    return key;
  }

  //конвертація IPv4 в число
  static int IPv4ToInt(string ip = "127.0.0.1")
  {
    string[] parts = ip.Split('.');
    int a = int.Parse(parts[0]);
    int b = int.Parse(parts[1]);
    int c = int.Parse(parts[2]);
    int d = int.Parse(parts[3]);
    int result = (a << 24) + (b << 16) + (c << 8) + d;
    return result;
  }

  static void Main()
  {
    Console.WriteLine("Випадкове число (5–10): " + RandomNumber(5, 10));
    Console.WriteLine("Випадкове число (0–10): " + RandomNumber(10));

    string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
    Console.WriteLine("Ключ: " + GenerateKey(16, chars));

    Console.WriteLine("127.0.0.1 -> " + IPv4ToInt("127.0.0.1"));
    Console.WriteLine("10.0.0.1 -> " + IPv4ToInt("10.0.0.1"));
  }
}
