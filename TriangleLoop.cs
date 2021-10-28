using System;

public class TriangleLoop
{
  private int baseAccount;
  private int middlePoint;
  public void Charecter(int sideLength)
  {
             middlePoint = sideLength - 1;
             baseAccount = sideLength * 2 - 1;
            
            for (int i = 0; i < sideLength; i++)
            {
                for (int k = 0; k < baseAccount; k++)
                {
                    if ((i + k == middlePoint || k - i ==middlePoint))
                    {
                       Console.Write("*");
                    }
                    else if ((i + k >= middlePoint && k - i <= middlePoint))
                    {
                        Console.Write("*");
                    }
                    else if (i == middlePoint)
                        Console.Write("*");
                    else
                         Console.Write(" ");
 
                }

                Console.WriteLine();
               
            }
  }
}