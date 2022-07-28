using System;

namespace ChapterSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------question 1-----------------");
            Console.WriteLine("Enter first number: ");
            int length = int.Parse(Console.ReadLine());

            for(int i = 1; i < length; i++)
               Console.WriteLine(i);


           Console.WriteLine("-----------------question 2-------------------");
           Console.WriteLine("Enter N: ");
           int length = int.Parse(Console.ReadLine());

           for (int i = 1; i < length; i++)
           {
               if (i % (3 * 7) != 0) Console.WriteLine(i);
           }  


           Console.WriteLine("---------------------question 3--------------------");
           int smallest = 0;
           int largest = 0;
           int input;
           Console.WriteLine("Enter the length of numbers: ");
           int length = int.Parse(Console.ReadLine());

           for (int i = 0; i < length; i++)
           {
               Console.WriteLine("Enter number: ");
               input = int.Parse(Console.ReadLine());
               if (i == 0) smallest = largest = input;
               else
               {
                   if (smallest > input) smallest = input;
                   if (largest < input) largest = input;
               }
           } 
           Console.WriteLine("Smallest - {0}, Largest - {1}", smallest, largest);


           Console.WriteLine("---------------------question 6-------------------");
           Console.WriteLine("Enter N: (1<K<N) ");
           int n = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter K: (1<K<N) ");
           int k = int.Parse(Console.ReadLine());

           for (int i = n - 1; i > 0; i--)
           {
               n *= i;
           } 
           for (int i = k - 1; i > 0; i--)
           {
               k *= i;
           }
           n /= k;
           Console.WriteLine("Result is {0}", n);


           Console.WriteLine("------------------question 10------------------");
           Console.WriteLine("Enter N: (N < 20) ");
           int n = int.Parse(Console.ReadLine());

           for (int i = 1; i <= n; i++)
           {
               for (int j = i; j <= i; j++)
               {
                   Console.WriteLine("{0}", j);
               }
               Console.ReadLine();
           }


           Console.WriteLine("------------------question 12-----------------");
           Console.WriteLine("Enter number: ");
           int n = int.Parse(Console.ReadLine());
           string binary = Convert.ToString(n, 2);
           Console.WriteLine("Result is {0}", binary);


        
           Console.WriteLine(" Question 4 ");
             for (int suits = 0; suits < 4; suits++)
            {
                if(suits != 0)
                { 
                Console.WriteLine();
                }
                for (int cards = 0; cards < 13; cards++)
                {
                    switch (suits)
                    {
                        case 0: 
                        Console.Write("Hearts "); 
                        break;
                        case 1:
                         Console.Write("Diamonds ");
                        break;
                        case 2: 
                        Console.Write("Spades "); 
                        break;
                        case 3: 
                        Console.Write("Clubs ");
                        break;
                    }
                    switch(cards)
                    {
                        case 0: 
                        Console.WriteLine("2"); 
                        break;
                        case 1: 
                        Console.WriteLine("3"); 
                        break;
                        case 2: 
                        Console.WriteLine("4"); 
                        break;
                        case 3: 
                        Console.WriteLine("5");
                        break;
                        case 4:
                        Console.WriteLine("6"); 
                        break;
                        case 5: 
                        Console.WriteLine("7"); 
                        break;
                        case 6: 
                        Console.WriteLine("8"); 
                        break;
                        case 7: 
                        Console.WriteLine("9"); 
                        break;
                        case 8: 
                        Console.WriteLine("10"); 
                        break;
                        case 9: 
                        Console.WriteLine("J"); 
                        break;
                        case 10: 
                        Console.WriteLine("Q"); 
                        break;
                        case 11: 
                        Console.WriteLine("K"); 
                        break;
                        case 12: 
                        Console.WriteLine("A"); 
                        break;
                    }
                }
            }
              Console.WriteLine();


              Console.WriteLine(" Question 5 ");
             int firstNo = 0;
             int secondNo = 1;
             Console.Write("Enter Number : ");
             int fibonacciNo = int.Parse(Console.ReadLine());
             Console.Write($" {firstNo}, {secondNo},");
             int sum = 1;
             for(int p = 2; p < fibonacciNo; p++)
             {
                
                int thirdNo = firstNo + secondNo;
                Console.Write($"{thirdNo},");
                firstNo = secondNo;
                secondNo = thirdNo;
                sum += thirdNo;
             }	
             Console.WriteLine($"The sum is : {sum}");
             Console.WriteLine();


             Console.WriteLine(" Question 7 ");
             Console.Write("Enter N : ");
             int numberN = int.Parse( Console.ReadLine());
             Console.Write("Enter K : ");
             int numberK = int.Parse(Console.ReadLine());
             decimal factorialN = 1;
             decimal factorialK = 1;
             int subtractionOfNAndK = numberN - numberK;
             decimal subtractionFactorial = 1;
             do
             {
                 factorialN *= numberN;
                 numberN--;
             } while (numberN > 0);
             do
             {
               factorialK *= numberK;
               numberK--;
             } while(numberK > 0);
             do
             {
                 subtractionFactorial *= subtractionOfNAndK;
                 subtractionOfNAndK--;
             } while(subtractionOfNAndK > 0);
             Console.WriteLine($"N!*K!/(N-K)! is {factorialN * factorialK / (subtractionFactorial)}");
             Console.WriteLine();

             
             Console.WriteLine(" Question 8 : ");
             Console.Write("Enter N : ");
             int nNo = int.Parse(Console.ReadLine());
             int nNoTimesTwo = nNo * 2;
             int nNoPlusOne = nNo + 1;
             int nNoFactorial = 1;
             int nNoPlusOneFactorial = 1;
              int nNoTimesTwoFactorial = 1;
             do
             {
                nNoFactorial *= nNo;
                nNo--;
             } while(nNo > 0);
             do
             {
                nNoTimesTwoFactorial *= nNoTimesTwo;
                nNoTimesTwo--;
             } while(nNoTimesTwo > 0);
             do
             {
                nNoPlusOneFactorial *= nNoPlusOne;
                nNoPlusOne--;
             } while(nNoPlusOne > 0);
             Console.WriteLine($"(2n)!/(n+1)!n! is equal to : { (nNoTimesTwoFactorial) / (nNoPlusOneFactorial) * (nNoTimesTwoFactorial)}");
             Console.WriteLine();
        } 
    }
}