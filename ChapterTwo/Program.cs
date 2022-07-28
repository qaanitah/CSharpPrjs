using System;

namespace ChapterOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------question 1--------------");
            ushort num1 = 52130;
            sbyte num2 = -115;
            uint num3 = 4825932;
            byte num4 = 97;
            short num5 = -10000;
            short num6 = 20000;
            byte num7 = 224;
            uint num8 = 970700000;
            sbyte num9 = 112;
            sbyte num10 = -44;
            int num11 = -1000000;
            ushort num12 = 1990;
            long num13 = 123456789123456789;


            Console.WriteLine("---------------question 2---------------");
            double firstNum = 34.567839023;
            float secondNum = 12.345;
            double thirdNum = 8923.1234857;
            decimal fourthNum = 3456.091124875956542151256683467;


            Console.WriteLine("----------------question 3---------------");
            decimal firstNumber = 4.67543421794m;
            decimal secondNumber = 7.4326765838m;
            firstNumber += secondNumber;
            Console.WriteLine(firstNumber);


            Console.WriteLine("---------------question 6 -----------------");
            bool isMale = false;


            Console.WriteLine("---------------question 7------------------");
            string firstWord = "Hello";
            string secondWord = "World";
            object concatenation = firstWord + " " + secondWord;


            Console.WriteLine("--------------question 8-------------------");
            string word1 = "Hello";
            string word2 = "World";
            object concatenate = word1 + " " + word2;
            string word3 = concatenate.ToString();


            Console.WriteLine("-------------question 9---------------");
            string sentence = "The \"use\" of quotations causes difficulties";
            Console.WriteLine(sentence);

            string phrase = "\"The \"use\" of quotations causes difficulties\"";
            Console.WriteLine(phrase);


            Console.WriteLine("--------------question 10--------------");
            Console.WriteLine("   o     o  ");
            Console.WriteLine("  o   o   o ");
            Console.WriteLine("  o       o ");
            Console.WriteLine("   o     o  ");
            Console.WriteLine("      o     ");


           Console.WriteLine("---------------question 11----------------");
           Console.WriteLine("     c    ");
           Console.WriteLine("   c   c  ");
           Console.WriteLine("  c     c ");
           Console.WriteLine(" c c c c c ");
           

           Console.WriteLine("---------------question 12---------------");
           Console.WriteLine("Enter your firstName: ");
           string firstName =(Console.ReadLine());
           Console.WriteLine("Enter your lastName: ");
           string lastName = (Console.ReadLine());
           Console.WriteLine("Enter your age: ");
           int age = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter your gender: ");
           string gender = (Console.ReadLine());
           Console.WriteLine("Enter your employee number: ");
           int num = int.Parse(Console.ReadLine());


           Console.WriteLine("-------------question 13-----------------");
           int x = 5;
           int y = 6;
           x = x + y;
           y = x - y;
           x = x - y;
           Console.WriteLine("x: {0} y: {1}", x, y);



           Console.WriteLine("------------------question 4----------------");
           int hexadecimalNumber = 0x100;
           Console.WriteLine("hexadecimalNumber");


           Console.WriteLine("---------------question 5----------------");
           char character = '\u0072';
           Console.WriteLine(character);



           




        } 
    }
}
