using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      Console.WriteLine("How much would you like to convert");
      string totalAsString = Console.ReadLine();
      
      double totalAsDouble = Convert.ToDouble(totalAsString);
      Console.WriteLine($"{totalAsDouble} is equal to...");

      int goldValue = 10;
      int silverValue = 5;

      double goldCoins = Math.Floor(totalAsDouble / 10);
      double leftOver = goldCoins % 10;
      double silverCoins = Math.Floor(leftOver / 5);
      leftOver = leftOver % silverValue;
      
    }
  }
}
