using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Please input a number to count to:");
    int number = int.Parse(Console.ReadLine());

    for (int i = 1; i < number; i++) 
    {
      if ((i % 3) == 0)
      {
        Console.WriteLine("ping");
      } else if ((i % 5) == 0)
      {
        Console.WriteLine("pong");
      }
      Console.WriteLine(i.ToString());
    }
  }
}