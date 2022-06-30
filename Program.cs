using System;

namespace AlphaApp
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("FIRST WORD = ");
        //    string firstWord = Console.ReadLine();
        //    Console.WriteLine("This word has " + firstWord.Length + " letters.");
        //    Console.WriteLine("SECOND WORD = ");
        //    string secondWord = Console.ReadLine();
        //    Console.WriteLine("This word has " + secondWord.Length + " letters.");
        //    int totalWordLength = firstWord.Length + secondWord.Length;
        //    Console.WriteLine("The total word length is " + totalWordLength);




        //    decimal cp = 200.876m;
        //    decimal sp = 255.425m;
        //    decimal profit = (sp - cp);
        //    decimal rounded = Math.Round(profit, 2);
        //    Console.WriteLine(rounded);




        // bool any = true;
        // if(any == true);
        // {
        //     Console.WriteLine("true");
        // }
        // else;
        // {
        //     Console.WriteLine("false");
        // }


        //  int age = 20;
        //  if( age >10 && age < 15)
        //  {
        //      Console.WriteLine("You are still a teenager!");
        //  }
        //  else if (age >15)
        //  {
        //      Console.WriteLine("You are no more a teenager");
        //  }



        // Random random = new Random();
        // int noOfDaysLeft = random.Next(11);
        // int discount = 0;
        // if(noOfDaysLeft <= 10 && noOfDaysLeft >= 6)
        // {
        //     Console.WriteLine("yOUR SUBSCRIPTION WILL EXPIRE SOON");
        // }
        // if(noOfDaysLeft <= 5 && noOfDaysLeft >=3)
        // {

        //     Console.WriteLine("yOUR SUBSCRIPTION WILL EXPIRE IN " + noOfDaysLeft + " DAYS,\n RENEW NOW AND GET " + (discount + 10)+ "%  DISCOUNT!");
        // }
        // if(noOfDaysLeft == 2)
        // {
        //     Console.WriteLine("yOUR SUBSCRIPTION WILL EXPIRE IN " + noOfDaysLeft + " DAYS,\n RENEW NOW AND GET " + (discount + 20)+ "%  DISCOUNT!");
        // }
        // if(noOfDaysLeft == 1)
        // {
        //     Console.WriteLine("yOUR SUBSCRIPTION WILL EXPIRE IN A DAY");
        // }
        // if(noOfDaysLeft == 0)
        //     Console.WriteLine("yOUR SUBSCRIPTION HAS EXPIRED!");


        // var phoneNumber = 08132267382;
        //  string num = phoneNumber.ToString();
        // foreach(char number in num)
        // {
        //     if(number % 2 != 0);
        //     {
        //         Console.WriteLine(number);
        //     }
        // }
        // else 
        // {
        //    Console.WriteLine(number);
        // }
         
        


        string[] months = new string[12]
         {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
         
          Console.WriteLine("-------------------Question 1-------------------.\n The number of months is " + months.Length + ".");
          Console.WriteLine("-------------------Question 2-------------------.");
          for(var i=0; i<months.Length; i++)
          {
              Console.WriteLine($"Element in index {i} is {months[i]}");
              
          }
            Console.WriteLine("-------------------Question 3-------------------.");
            Console.WriteLine($"The reverse of the elements in the array is :");
          for(int reverse = months.Length - 1; reverse >= 0; reverse--)
          {
              Console.WriteLine(months[reverse] + " ");
          }
          Console.WriteLine("-------------------Question 5-------------------.");
          string[] secondArray = new string[6];
            Array.Copy(months, 0, secondArray, 0, 6);
            foreach(string item in secondArray)
            Console.WriteLine(item);


            Console.WriteLine("-------------------Question 4-------------------.");
            Array.Sort(months);
            Console.WriteLine(String.Join("\n", months));

            
        }
    }
}
