using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter the length of one side of a triangle");
    string stringSideOne = Console.ReadLine();
    Console.WriteLine("Enter the length of one side of a triangle");
    string stringSideTwo = Console.ReadLine();
    Console.WriteLine("Enter the length of one side of a triangle");
    string stringSideThree = Console.ReadLine();

    int sideOne = int.Parse(stringSideOne);
    int sideTwo = int.Parse(stringSideTwo);
    int sideThree = int.Parse(stringSideThree);

    int sum1 = sideOne + sideTwo;
    int sum2 = sideTwo + sideThree;
    int sum3 = sideThree + sideOne;

    if (sum1 < sideThree || sum2 < sideOne || sum3 < sideTwo)
    {
      Console.WriteLine("Not a triangle");
    }
    else
    {
      if (sideOne == sideTwo && sideTwo == sideThree && sideThree == sideOne)
      {
        Console.WriteLine("Equilateral Triangle");
      }
      else if (sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree)
      {
        Console.WriteLine("Isosceles Triangle");
      }
      else if (sideOne != sideTwo && sideTwo != sideThree && sideThree != sideOne)
      {
        Console.WriteLine("Scalene Triangle");
      }

    }
  }
}
