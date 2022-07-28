using System;

namespace ChapterSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------question 1--------------------");
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }


            Console.WriteLine("question 2");
            Console.Write("Enter Length Of The First Array : ");
           int firstLength = int.Parse(Console.ReadLine());
           int [] firstArrayIntegers = new int [firstLength];
           int p;
           for(p = 0; p < firstLength; p++)
           {
               Console.Write("Enter Element[{0}] = ", p);
               firstArrayIntegers[p] = int.Parse(Console.ReadLine());
           }
           Console.WriteLine();
           Console.WriteLine("******");
           Console.Write("Enter Length Of Second Array : ");
           int secondLength = int.Parse(Console.ReadLine());
           int [] secondArrayIntegers = new int [secondLength];
           int q;
           for(q = 0; q < secondLength; q++)
           {
               Console.Write("Enter Element[{0}] = ", q);
               secondArrayIntegers[q] = int.Parse(Console.ReadLine());
           }
           Console.WriteLine();
           Console.WriteLine("******");
           if(firstLength != secondLength && firstArrayIntegers[p] != secondArrayIntegers[q])
           {
               Console.WriteLine("The two arrays are not equal");
           }
           else
           {
               Console.WriteLine("The two arrays are equal");
           }
           Console.WriteLine();

            
           Console.WriteLine(" Question 3 ");
           char [] alphabets1 = new char [9] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I'};
           char [] alphabets2 = new char [10] {'Z', 'Y', 'X', 'W', 'V', 'U', 'T', 'S', 'R', 'Q'};
           bool alphabetsEqual = false;
           if (alphabets1.Length < alphabets2.Length)
           {
             Console.WriteLine("First array is lexicographically first.");
           }
           else if (alphabets1.Length > alphabets2.Length)
           {
             Console.WriteLine("Second array is lexicographically first.");
           }
           else
            {
                for (int i = 0; i < alphabets1.Length; i++)
                {
                    if (alphabets1[i] < alphabets2[i])
                    {
                        Console.WriteLine("First array is lexicographically first.");
                        alphabetsEqual = false;
                        break;
                    }
                    if (alphabets1[i] > alphabets2[i])
                    {
                        Console.WriteLine("Second array is lexicographically first.");
                        alphabetsEqual = false;
                        break;
                    }
                }
                if(!alphabetsEqual)
                {
                Console.WriteLine("Arrays are lexicographicaly equal.");
                }
            }
            Console.WriteLine();

            
            Console.WriteLine(" Question 4 ");
            int counter = 1; 
            int temporaryCounter = 1; 
            int number = 0;
            Console.Write ("Enter The Length Of The Array : ");
			int length = int.Parse(Console.ReadLine ());
			int [] arrayNumbers = new int [length];

			for (int i = 0; i < length; i++) 
			{
				Console.Write ("Enter Element[{0}] : ", i);
				arrayNumbers[i] = int.Parse (Console.ReadLine ());
			}
            for (int i = 0; i < length - 1; i++) 
			{
                if (arrayNumbers[i] == arrayNumbers[i + 1]) 
                {
                   temporaryCounter++;
                }
                else 
                {
                   temporaryCounter = 1;
                }

				if (temporaryCounter > counter) 
				{
					counter = temporaryCounter;
					number = arrayNumbers[i];
				}
			}
            for(int i = 0; i < counter; i++) 
            {
                Console.Write ("Element[{0}]", number);
            }
            Console.WriteLine();
            
        }
    }
}
