using System;

namespace ChapterFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------question 1--------------------");
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            Console.WriteLine("First number - {0}, Second number - {1}.", a, b);


            Console.WriteLine("---------------------question 3-------------------");
            Console.WriteLine("Input first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Input third number: ");
            int z = int.Parse(Console.ReadLine());

            if(x > y)
               if (x > z) Console.WriteLine("X is the biggest");
               else if (x < z) Console.WriteLine("Z is the biggest");
               else Console.WriteLine("X and Z are the biggest");
            else if (x < y)
               if (y > z) Console.WriteLine("Y is the biggest");
               else if (x > z) Console.WriteLine("Z is the biggest");
               else Console.WriteLine("Y and Z are the biggest");
            else if (x == y)
            if (x == z) Console.WriteLine("All are equal");
            else if (x < z) Console.WriteLine("Z is the biggest");
            else Console.WriteLine("X and Y are the biggest"); 


            Console.WriteLine("-------------------question 4--------------------------- ");
            Console.WriteLine("Input first number: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("Input third number: ");
            int r = int.Parse(Console.ReadLine());

            if (p < q)
            {
                if (p < r)
                {
                    p = p + r;
                    r = p - r;
                    p = p - r;

                    if (q > r)
                    {
                       p = p + q;
                       q = p - q;
                       p = p - q;
                    }
                }
                else if (p >= r)
                {
                    p = p + q;
                    q = p - q;
                    p = p - q;
                }
            }
            else if ( p == q)
            {
                if ( p < r)
                {
                    p = p + r;
                    r = p - r;
                    p = p - r;
                }
            } 
            else
            {
                if (q < r)
                {
                    q = q + r;
                    r = q - r;
                    q = q - r;
                }
                if (p < q)
                {
                    p = p + q;
                    q = p - q;
                    p = p - q;
                }
            }
            Console.WriteLine("{0}, {1}, {2}", p, q, r);
            Console.ReadLine();


            Console.WriteLine("------------------------question 6------------------");
            Console.WriteLine("Enter J (not 0): ");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter L: ");
            int l = int.Parse(Console.ReadLine());

            int m = (int)(k * k - 4 * j * l);
            if (m < 0)
                Console.WriteLine("\nM={0}\nThere no real roots.", m);
            else if (m == 0)
            {
                int x1 = (int)(-k / 2 * j);
                Console.WriteLine("\nX={0}", x1);
            } 
            else
            {
                int x1 = (int)((-k + Math.Sqrt(m)) / (2 * j));
                int x2 = (int)((-k - Math.Sqrt(m)) / (2 * j));
                Console.WriteLine("\nX1={0}\nX2={1}", x1, x2);
            }   
            Console.ReadLine(); 



            Console.WriteLine("----------------------question 10-------------");
            int points;
            Console.WriteLine("Enter points between 1 and 9: ");
            points = int.Parse(Console.ReadLine());
            if (points >= 1 && points <= 3)
                Console.WriteLine("Points multiplied by 10: {0}", points * 10);
            else if (points >= 4 && points <= 6)
                Console.WriteLine("Points multiplied by 100:", points * 100);
            else if (points >= 7 && points <= 9)
                Console.WriteLine("Points multiplied by 1000:", points * 1000);
            else
               Console.WriteLine("Wrong Input!");
            Console.ReadLine();  


          Console.WriteLine(" Question 2 ");
          Console.Write("Enter First Number : ");
          int number1 = int.Parse(Console.ReadLine());
          Console.Write("Enter Second Number : ");
          int number2 = int.Parse(Console.ReadLine());
          Console.Write("Enter Third Number : ");
          int number3 = int.Parse(Console.ReadLine());
          if(number1 * number2 * number3 < 0)
          {
              Console.WriteLine("-");
          }
          if(number1 * number2 * number3 == 0)
          {
              Console.WriteLine("0");
          }
          if(number1 * number2 * number3 > 0)
          {
              Console.WriteLine("+");
          }



          Console.WriteLine("question 5");
          Console.WriteLine("Please enter a number between 0 and 9:");
          string numbers = Console.ReadLine();
 
          switch (numbers)
          {
               case "0": 
               Console.WriteLine("Zero");
               break;
               case "1": 
               Console.WriteLine("One"); 
               break;
               case "2": 
               Console.WriteLine("Two"); 
               break;
               case "3": 
               Console.WriteLine("Three"); 
               break;
               case "4": 
               Console.WriteLine("Four");
               break;
               case "5": 
               Console.WriteLine("Five"); 
               break;
               case "6": 
               Console.WriteLine("Six"); 
               break;
               case "7": 
               Console.WriteLine("Seven"); 
               break;
               case "8": 
               Console.WriteLine("Eight"); 
               break;
               case "9": 
               Console.WriteLine("Nine"); 
               break;
               default: 
               Console.WriteLine("Not a digit"); 
               break;
          }
          Console.WriteLine();


          Console.WriteLine("question 7");
          Console.WriteLine("Number 1 : ");
         int firstNo = int.Parse(Console.ReadLine());
         Console.WriteLine("Number 2 : ");
         int secondNo = int.Parse(Console.ReadLine());
         Console.WriteLine("Number 3 : ");
         int thirdNo = int.Parse(Console.ReadLine());
          Console.WriteLine("Number 4 :");
         int fourthNo = int.Parse(Console.ReadLine());
         Console.WriteLine("Number 5 : ");
         int fifthNo = int.Parse(Console.ReadLine());
         if ((firstNo >= secondNo) && (firstNo >= thirdNo) && (firstNo >= fourthNo) && (firstNo >= fifthNo))
         {
            Console.WriteLine($"The biggest number is: {firstNo}");
            
         }
         if ((secondNo >= firstNo) && (secondNo >= thirdNo) && (secondNo >= fourthNo) && (secondNo >= fifthNo))
         {
            Console.WriteLine($"The biggest number is : {secondNo}");
            
         }
         if ((thirdNo >= firstNo) && (thirdNo >= secondNo) && (thirdNo >= fourthNo) && (thirdNo >= fifthNo))
         {
            Console.WriteLine($"The biggest number is : {thirdNo}");
            
         }
         if ((fourthNo >= firstNo) && (fourthNo >= secondNo) && (fourthNo >= thirdNo) && (fourthNo >= fifthNo))
         {
            Console.WriteLine($"The biggest number is : {fourthNo}");
            
         }
         if ((fifthNo >= firstNo) && (fifthNo >= secondNo) && (fifthNo >= thirdNo) && (fifthNo >= fourthNo))
         {
            Console.WriteLine($"The biggest number is : {fifthNo}");
            
         }
         Console.WriteLine();

         /*8. Write a program that, depending on the user’s choice, inputs int, double or string variable. If the variable is int or double, the program increases it by 1. If the variable is a string, the program appends "" at the end. Print the result at the console. Use switch statement.*/
          Console.WriteLine(" Question 8 ");
          Console.Write("Enter 1 for int, 2 for double and 3 for string \nEnter Number : ");
          int variable = int.Parse(Console.ReadLine());
          
          switch (variable)
         {
           case 1 :
           Console.Write("Enter Input For Variable int : ");
           int intVariable = int.Parse(Console.ReadLine());
           Console.WriteLine(++intVariable);
           break;
           case 2 :
           Console.WriteLine("Enter Input For Variable double : ");
           double doubleVariable = double.Parse(Console.ReadLine());
           Console.WriteLine(++doubleVariable);
           break;
           case 3 :
           Console.Write("Enter Input For Variable string : ");
           string stringVariable = Console.ReadLine();
           Console.WriteLine($"{variable}*");
           break;
           default :
           Console.WriteLine("Invalid variable!");
           break;
         }

         /*9. We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:
         - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.
         - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0.*/
         Console.WriteLine(" Question 9 ");
         Console.Write("Enter First Number : ");
         int num1 = int.Parse(Console.ReadLine());
         Console.Write("Enter Second Number : ");
         int num2 = int.Parse(Console.ReadLine());
         Console.Write("Enter Third Number : ");
         int num3 = int.Parse(Console.ReadLine());
         Console.Write("Enter Fourth Number : ");
         int num4 = int.Parse(Console.ReadLine());
         Console.Write("Enter Fifth Number : ");
         int num5 = int.Parse(Console.ReadLine());
         if(num1 + num2 == 0)
         {
            Console.WriteLine($"{num1 + num2}");
         }
         if(num1 + num3 == 0)
         {
            Console.WriteLine($"{num1 + num3}"); 
         }
         if(num1 + num4 == 0)
         {
            Console.WriteLine($"{num1 + num4}");
         }
         if(num1 + num5 == 0)
         {
            Console.WriteLine($"{num1 + num5}");
         }
         if(num2 + num3 == 0)
         {
            Console.WriteLine($"{num2 + num3}");
         }
         if(num2 + num4 == 0)
         {
            Console.WriteLine($"{num2 + num4}");
         }
         if(num2 + num5 == 0)
         {
            Console.WriteLine($"{num2 + num5}");
         }
         if(num3 + num4 == 0)
         {
            Console.WriteLine($"{num3 + num5}");
         }
         if(num3 + num5 == 0)
         {
            Console.WriteLine($"{num3 + num5}");
         }
         if(num4 + num5 == 0)
         {
            Console.WriteLine($"{num4 + num5}");
         }
         if(num1 + num2 + num3 == 0)
         {
            Console.WriteLine($"{num1 + num2 + num3}");
         }
         if(num1 + num2 + num4 == 0)
         {
            Console.WriteLine($"{num1 + num2 + num4}");
         }
         if(num1 + num2 + num5 == 0)
         {
            Console.WriteLine($"{num1 + num2 + num5}");
         }
         if(num1 + num3 + num4 == 0)
         {
            Console.WriteLine($"{num1 + num3 + num4}");
         }
         if(num1 + num3 + num5 == 0)
         {
            Console.WriteLine($"{num1 + num3 + num5}");
         }
         if(num2 + num3 + num4 == 0)
         {
            Console.WriteLine($"{num2 + num3 + num4}");
         }
         if(num2 + num4 + num5 == 0)
         {
            Console.WriteLine($"{num2 + num4 + num5}");
         }
         if(num3 + num4 + num5 == 0)
         {
            Console.WriteLine($"{num2 + num3 + num4}");
         }
         Console.WriteLine();

         


            
              
        }
    }
}