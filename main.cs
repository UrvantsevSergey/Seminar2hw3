using System;

class Program 
{
  public static void Main (string[] args)
  {
    metka1:
    Console.Write("Введите корректное число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    while (a >= 10 && a <= 99)
    {
      int x = a%10;
      int y = a/10;
      if (x > y)
      {
        Console.WriteLine($"Наибольшее число {x}");
        break;
      }
      else if (x < y)
      {
        Console.WriteLine($"Наибольшее число {y}");
        break;
      }
      else 
      { 
        Console.WriteLine($"Числа {x} и {y} равны");
        break;
      }
    }
    goto metka1;
  }
}