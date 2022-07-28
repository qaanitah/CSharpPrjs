using System;

namespace ChapterFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------question 1----------------");
            Console.WriteLine("First number: ");
            int firstNu = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            int secondNu = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Third number: ");
            int thirdNu = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sum is {0}", firstNu + secondNu + thirdNu);

            Console.WriteLine("------------------question 2--------------------");
            Console.WriteLine("Enter r: ");
            double r = double.Parse(Console.ReadLine());
            double area = (Math.PI * r * r );
            double perimeter = (2 * Math.PI * r);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);


            Console.WriteLine("-------------------question 3--------------------");
            Console.WriteLine("Enter the company's name: ");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter the company's address: ");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Enter your phone number: ");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your fax number: ");
            long faxNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the company's website: ");
            string website = Console.ReadLine();
            Console.WriteLine("Enter the manager's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the manager's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the manager's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the manager's phone number: ");
            long managerPhoneNumber = long.Parse(Console.ReadLine());


            Console.WriteLine("Name:{0}", companyName);
            Console.WriteLine("Address:{0}", companyAddress);
            Console.WriteLine("Phonenumber: {0}", phoneNumber);
            Console.WriteLine("Faxnumber: {0}", faxNumber);
            Console.WriteLine("Web-site: {0}", website);
            Console.WriteLine("Manager: {0}" + " " + "{1}" + " " + "age: {2}," + " " + "Phonenumber: {3}", firstName, lastName, age, managerPhoneNumber);



            Console.WriteLine("--------------------question 4---------------------");
            int hexNum = 432;
            double fractNo = 234.6769;
            double negativeFractNo = -234.6769;
            Console.WriteLine("|{0, -10:x}|", hexNum);
            Console.WriteLine("|{0, -10:f}|", fractNo);
            Console.WriteLine("|{0, -10:f}|", negativeFractNo);


            Console.WriteLine("-----------------------question 5--------------------");
            int counter = 0;
            
            Console.WriteLine("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());

            for(int i = a; i <= b; i++)
            {
                if (i % 5 == 0) counter++;
            }
            
            Console.WriteLine("{0} Numbers found.", counter);


            Console.WriteLine("-----------------------question 6---------------------");
            Console.WriteLine("Input the First number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double greaterNumber = Math.Max(num1, num2);
            Console.WriteLine("Number {0} is greater", greaterNumber);


            Console.WriteLine("-----------------question 7----------------------------");
            Console.WriteLine("Input first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Third number: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Fourth number: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Fifth number: ");
            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum is {0}", num1 + num2 + num3 + num4 + num5 );


            Console.WriteLine("-------------------------question 8------------------------------- ");
            Console.WriteLine("Enter first number: ");
            int firstNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int thirdNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fourth number: ");
            int fourthNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fifth number: ");
            int fifthNo = int.Parse(Console.ReadLine());
            if((firstNo > secondNo && firstNo > thirdNo && firstNo > fourthNo && firstNo > fifthNo))
            {
                Console.WriteLine($"The greatest number: {firstNo}");
            }
            if((secondNo > firstNo && secondNo > thirdNo && secondNo > fourthNo && secondNo > fifthNo))
            {
                Console.WriteLine($"The greatest number: {secondNo}");
            }
            if((thirdNo > firstNo && thirdNo > secondNo && thirdNo > fourthNo && thirdNo > fifthNo))
            {
                Console.WriteLine($"The greatest number: {thirdNo}");
            };
            if((fourthNo > firstNo && fourthNo > secondNo && fourthNo > thirdNo && fourthNo > fifthNo))
            {
                Console.WriteLine($"The greatest number: {fourthNo}");
            }
            if((fifthNo > firstNo && fifthNo > secondNo && fifthNo > thirdNo && fifthNo > fourthNo))
            {
                Console.WriteLine($"The greatest number: {fifthNo}");
            }


            Console.WriteLine("-----------------------question 9-------------------");
            int sum = 0;
            Console.WriteLine("Enter numbers: ");
            int length = int.Parse(Console.ReadLine());
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter {0} number: ", i + 1);
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of all numbers is {0}. ", sum);


            Console.WriteLine("-------------------question 10---------------------");
            Console.WriteLine("Input numbers: ");
            int range = int.Parse(Console.ReadLine());
            for (int i = 1; i <= range; i++)
            {
                Console.WriteLine(i);
            }
            

            Console.WriteLine("-------------------question 11-------------------");
            int num1 = 0;
            int num2 = 1;
            int sum = 1;
            int count = 0;

            Console.WriteLine(num1);
            while(count < 100)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                Console.WriteLine(num2);
                count ++;
            }


            Console.WriteLine("-----------------------question 12---------------------");
            Console.Write("Enter Length : ");
            double length = double.Parse(Console.ReadLine());
            double summingUp = 1.0d;
            for(int i = 2; i <= length; i++)
            {
              if(i % 2 == 0)
              {
                 summingUp += (1.0 / i);
              }
              else if(i % 2 != 0)
              {
                 summingUp += ( 1.0 / -i);
              }
            }
            double roundUpTo3DecimalPlaces = (double) Math.Round(summingUp, 3);
            Console.WriteLine(roundUpTo3DecimalPlaces);
            Console.WriteLine();
            
            
            
                
            
        
        }
    }   
}   