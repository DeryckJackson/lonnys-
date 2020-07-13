using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Please input a number to count to:");
    int number = int.Parse(Console.ReadLine());

    for (int i = 1; i < number; i++) 
    {
      if ((i % 15) == 0)
      {
        Console.WriteLine("ping-pong");
      } 
      else if ((i % 5) == 0)
      {
        Console.WriteLine("pong");
      } 
      else if ((i % 3) == 0) 
      {
        Console.WriteLine("ping");
      }

      Console.WriteLine(i.ToString());
    }
  }
}