using System;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Declare an array of months January - December");
            string[] months = {"January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December",};
            
            Console.WriteLine("Return the number of months in the array");
             Console.WriteLine($"The number of months is : {months.Length}");

              Console.WriteLine("Return the rank of the months");
              for (int num = 0; num < months.Length; num++)
              {
                  Console.WriteLine("{1}", num, months[num]);
              }
              Console.WriteLine("Reverse the months using loop method");
              for (int num = months.Length -1; num >= 0; num--)
              {
                  Console.WriteLine("{1}", num, months[num]);
              }
              Console.WriteLine("Reverse the months using array method");
              Array.Reverse(months);
              foreach(string m in months)
              {
                  Console.WriteLine(m);
              }
              Console.WriteLine("Sort the months Alphabetically using array method");
              Array.Sort(months);
              foreach(string m in months)
              {
                  Console.WriteLine(m);
              }

              Console.WriteLine("Sort the months Alphabetically using loop method");
              string set;
              {
                  for (int a = 0; a < months.Length; a++)
                  {
                     for (int b = 0; b < months.Length; b++)
                      {
                          if (b ! == months.Length -1)
                          {
                              if (months[b] > months[b+1])
                              {
                                  set = months[b];
                                  months[b] = months[b+1];
                                  months[b+a] = set;


                              }
                          }
                      }
                  }
              }
        }
    }
}
                        Console.WriteLine("Copy the first six months to an array");
                        string[] firstSixMonths = new string[6];
                        Array.Copy(months, 0, firstSixMonths, 0, 6);
                        foreach (string d in firstSixMonths)
                        {
                            Console.WriteLine(d);
                        }

                        Console.WriteLine("Clone the months using array method");
                        string[] monthsClone = (string[])months.Clone();
                        foreach(string element in monthsClone)
                        {
                            Console.WriteLine(elements);
                        }
                        Console.Read();

                        Console.WriteLine("clear months starting from 6");
                        Array.Clear(months, 0, 6);
                        foreach (string o in months)
                        {
                            Console.WriteLine(o);
                        }
                        Console.Read();

                        Console.WriteLine("Clear all the months");
                        Array.Clear(months, 0, months.Length);
                        foreach (string o in months)
                        {
                            Console.WriteLine(o);
                       } 
    