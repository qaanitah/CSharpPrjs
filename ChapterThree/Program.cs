using System;

namespace ChapterThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------question 1-------------------");
            Console.WriteLine("Enter any number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even."); 
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }


            Console.WriteLine("--------------question 2------------------");
            int n = int.Parse(Console.ReadLine());
            if (n % 5 == 0 && n % 7 ==0)
            {
                Console.WriteLine("{0} is divisible by both 5 and 7 without any remainder", n);
            }
            else
            {
                Console.WriteLine("{0} is not divisible by both 5 and 7 without any remainder", n);
            }


            Console.WriteLine("---------------------question 3-------------------");
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int thirdD = (number / 100) % 10;
            if (thirdD == 7)
            {
                Console.WriteLine("The third digit is seven! ");
            }
            else
            {
                Console.WriteLine("The third digit is not seven. ");
            }


            Console.WriteLine("----------------question 5----------------------");
            Console.WriteLine("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height: ");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;
            Console.WriteLine("The area of trapezoid is {0}" , area);


            Console.WriteLine("---------------------question 6----------------------");
            Console.WriteLine("Enter p: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter q: ");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S = {0}, P = {1}", p * q, (p + q) * 2);
            
        
            
            


            Console.WriteLine("---------------------question 7------------------------");
            Console.WriteLine("Enter the weight: ");
            double weightOnEarth = double.Parse(Console.ReadLine());
            double weightOnMoon = weightOnEarth * 0.17;
            Console.WriteLine("The weight on the Moon is: {1} kg.", weightOnEarth,weightOnMoon);


           
            Console.WriteLine("--------------------question 8----------------------------");
            Console.WriteLine("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            double d1 = (x * x) + (y * y);
            double d2 = Math.Sqrt(d1);
            
            int a1 = -1;
            int a2 = 5;
            int b1 = 1;
            int b2 = 5;
            double d3 = (a2-a1) * (a2-a1) - (b2-b1) * (b2-b1);
            double d4 = Math.Sqrt(d3);

            if(d2 <= 5 && d4 <= 5)
            {
                Console.WriteLine("It is within the circle and out of the rectangle");
            }
            else
            {
                Console.WriteLine("It is outside the circle and within the rectangle");
            }


            Console.WriteLine("----------------------question 10------------------");
            int n = int.Parse(Console.ReadLine());
            int numOne = (n / 1000) % 10;
            int numTwo = (n / 100) % 10;
            int numThree = (n / 10) % 10;
            int numFour = (n % 10);

            Console.WriteLine("The sum of the digits is: {0}", numOne + numTwo + numThree + numFour);
            Console.WriteLine("Reversed order: {0}{1}{2}{3}", numFour, numThree, numTwo, numOne);
            Console.WriteLine("Last digit at the front: {0}{1}{2}{3}", numFour, numOne, numTwo, numThree);
            Console.WriteLine("Exchanges the second and third digits: {0}{1}{2}{3}{4}", numOne, numThree, numTwo, numFour);



            Console.WriteLine("-------------------question 4--------------------");
            Console.WriteLine("Enter an integer = ");
            int integer = int.Parse(Console.ReadLine());
            bool bit3 = (integer & 8) != 0;
            Console.WriteLine(bit3);
            Console.WriteLine();


          Console.WriteLine("-----------------question 9-----------------");
          Console.WriteLine("Enter Value For x1 : ");
          int x1 = int.Parse(Console.ReadLine());
          Console.WriteLine("Enter Value For y1 : ");
          int y1 = int.Parse(Console.ReadLine());
          bool insideOfCircle = (x1 * x1) + (y1 * y1) <= 25;
          bool outOfRectangle = (x < -1 && x > 5) && (y < 1 && y > 5);
          if(insideOfCircle && outOfRectangle) 
          {
              Console.WriteLine("It is within the circle and out of the rectangle");
          }
          else
          {
              Console.WriteLine("It is not within the circle and in the rectangle");
          }

          Console.WriteLine();

          Console.WriteLine(" Question 11 ");
            Console.Write("Enter n : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter p : ");
            int p = int.Parse(Console.ReadLine());
            int counter = 1;
            int shiftLeft = counter << p;
            Console.WriteLine((n & shiftLeft) != 0 ? "Third bit is 1" : "Third bit is 0"); 
            Console.WriteLine();

            /*12. Write a Boolean expression that checks if the bit on position p in the integer v has the value  1. Example v=5, p=1 -> false.*/
            Console.WriteLine(" Question 12 ");
            Console.Write("Enter v : ");
            int v = int.Parse(Console.ReadLine());
            int positionP = int.Parse(Console.ReadLine());
            int shiftToTheLeft = 1 << p;
            bool isOne = (v & shiftToTheLeft) != 0 ? true : false;
            Console.WriteLine($"The bit at position {p} of number {v} is 1? {isOne}");
            Console.WriteLine();

            /*13. We are given the number n, the value v (v = 0 or 1) and the position p. write a sequence of operations that changes the value of n, so the bit on the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. Another example: n=35, p=2, v=1 -> n=39.*/
            Console.WriteLine(" Question 13 ");
            Console.Write("Enter nNumber : ");
             int nNumber = int.Parse(Console.ReadLine());
            int valueV = 0;
            int pPosition = int.Parse(Console.ReadLine());
            nNumber = (valueV == 0) ? nNumber = nNumber & (~(1 << pPosition)) : nNumber = nNumber | (1 << pPosition);
            Console.WriteLine(nNumber);
            Console.WriteLine();

            /*14. Write a program that checks if a given number n (1 < n < 100) is a prime number (i.e. it is divisible without remainder only to itself and 1).*/
            Console.WriteLine(" Question 14 ");
            Console.Write("Enter A Number Between 1 and 100 : ");
            int nNum = int.Parse(Console.ReadLine());
            int squareRootOfN = (int) Math.Sqrt(n);
            int divisor = 2;
            bool prime = true;
            while (prime && (divisor <= squareRootOfN))
            {
                if(nNum % divisor != 0)
                {
                    prime = true;
                    Console.WriteLine($"{nNum} is a prime number");
                }
                else
                {
                   prime = false;
                   Console.WriteLine($"{nNum} is not a prime number");
                }
                divisor++;
            }
            Console.WriteLine();


            /*15.  Write a program that exchanges the values of the bits on positions 3, 4 and 5 with bits on positions 24 25 and 26 of a given 32-bit unsigned integer.*/
            Console.WriteLine(" Question 15 ");
            Console.Write("Enter Number : ");
            int vNumber = int.Parse(Console.ReadLine());
            int shift = 1 << 3;
            int thirDBit = (vNumber &shift ) != 0 ? 1 : 0;
            shift = 1 << 4;
            int fourthBit= (vNumber & shift) != 0 ? 1 : 0;
            shift = 1 << 5;
            int fifthBit = (vNumber & shift) != 0 ? 1 : 0;
            shift = 1 << 24;
            int twentyFourthBit = (vNumber & shift) != 0 ? 1 : 0;
            shift = 1 << 25;
            int twentyFifthBit = (vNumber & shift) != 0 ? 1 : 0;
            shift = 1 << 26;
            int twentySixthBit = (vNumber & shift) != 0 ? 1 : 0;

            vNumber = (thirDBit == 0) ? vNumber = vNumber & (~(1 << 24)) : vNumber = vNumber | (1 << 24);
            vNumber = (fourthBit == 0) ? vNumber = vNumber & (~(1 << 25)) : vNumber = vNumber | (1 << 25);
            vNumber = (fifthBit == 0) ? vNumber = vNumber & (~(1 << 26)) : vNumber = vNumber | (1 << 26);
            vNumber = (twentyFourthBit == 0) ? vNumber = vNumber & (~(1 << 3)) : vNumber = vNumber | (1 << 3);
            vNumber = (twentyFifthBit == 0) ? vNumber = vNumber & (~(1 << 4)) : vNumber = vNumber | (1 << 4);
            vNumber = (twentySixthBit == 0) ? vNumber = vNumber & (~(1 << 5)) : vNumber = vNumber | (1 << 5);
            Console.WriteLine(vNumber);
            Console.WriteLine();
            
            


            
        
            


        }
    }
}
