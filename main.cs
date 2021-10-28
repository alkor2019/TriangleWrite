using System;

class Program {
  public static void Main (string[] args) {
         int sideLength;
            Console.Write("Uzunluk : ");
            sideLength = Convert.ToInt32(Console.ReadLine());
            TriangleLoop d =new TriangleLoop();
            d.Charecter(sideLength);
            Console.ReadKey();
  }
}