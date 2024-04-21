//Programmer:Brian Lee
//Date: 4/19/2024

//Title: CSI 120 Assignment 2
using System.Diagnostics.Metrics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSI_120_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem5();
            Problem6();
            Problem7();


        }//end of main
        public static void Problem1()
        {
            Console.WriteLine("Problem 1");
            Console.WriteLine();
            /*
             * 1. Write a program that prompts the user to input five decimal numbers.  Your program should do the following:

                a. Prompts the user to input five decimal numbers.

                b. Prints the five decimal numbers.

                c. Add the five decimal numbers.

                d. Print the sum and the average of the five decimals. Calculating the sum and the average are two separate calculations.
             * 
             */

            decimal[] userNum = new decimal[5]; //Create an array of zeroes to initalize User Number
            for (int i = 0; i < 5; i++) //For loop to ask for user number multiple times
            {
                bool validInput = false;
                while (!validInput)
                {
                    Console.Write($"Enter decimal number {i + 1}: ");
                    string userInput = Console.ReadLine();
                    if(decimal.TryParse(userInput, out decimal number)) //Check if the user input can be parsed into a decimal
                    {
                        userNum[i] = number;
                        validInput = true;

                    }
                    else
                    {
                        Console.WriteLine("Invalid Iput. Please try again.");
                    }
                }

            }
            Console.WriteLine($"Your Numbers are { string.Join(", ", userNum)}"); //print user number
            Console.WriteLine($"Your Sum of numbers are {userNum.Sum()}");  //sum the user number
            Console.WriteLine($"Your Average of numbers are {userNum.Average()}"); //average user number

            Console.WriteLine();
        }//end of Problem1
        public static void Problem2()
        {
            Console.WriteLine("Problem 2");
            Console.WriteLine();

            // Write a program that prompts the capacity, in gallons, of an automobile fuel tank and the miles per gallon the automobile can be driven. The program outputs the number of miles the automobile can be driven without refueling.
            double userGallons;
            double userMPG;

            Console.WriteLine("Enter the capacity, in gallons, of your car");

            while (!double.TryParse(Console.ReadLine(), out userGallons))
                Console.WriteLine("Invalid Input. Please try again.");
           


            Console.WriteLine("Enter the miles per gallon you car can drive");
            while (!double.TryParse(Console.ReadLine(), out userMPG))
                Console.WriteLine("Invalid Input. Please try again.");



            Console.WriteLine($"Your car can drive {userGallons*userMPG} miles");

            Console.WriteLine();
        }//end of Problem2
        public static void Problem3()
        {
            Console.WriteLine("Problem 3");
            Console.WriteLine();
            //Write a  program that prompts the user to input the elapsed time for an event in seconds. The program then outputs the elapsed time in hours, minutes, and seconds. (For example, if the elapsed time is 9630 seconds, then the output is 2:40:30.)

            int userSeconds;

            Console.WriteLine("Please enter the elapsed time in seconds.");
            while (!int.TryParse(Console.ReadLine(), out userSeconds)) ;
                Console.WriteLine("Invalid Input. Please try again");

            int hour = userSeconds / 3600;
            int minute = (userSeconds - (3600 * hour)) / 60;
            int second = (userSeconds - (3600 * hour) - (60 * minute));

            Console.WriteLine($"Your time is {hour}:{minute}:{second}");


            Console.WriteLine();
        }//end of Problem3
        public static void Problem4()
        {
            Console.WriteLine("Problem 4");
            Console.WriteLine();
            //Write a  program that prompts the user to input the elapsed time for an event in hours, minutes, and seconds. The program then outputs the elapsed time in seconds.

            int userHour,userMinute,userSecond;

            Console.WriteLine("Please enter the elapsed time in hour.");
            while (!int.TryParse(Console.ReadLine(), out userHour)) ;
                Console.WriteLine("Invalid Input. Please try again");

            Console.WriteLine("Please enter the elapsed time in seconds.");
            while (!int.TryParse(Console.ReadLine(), out userMinute)) ;
                Console.WriteLine("Invalid Input. Please try again");

            Console.WriteLine("Please enter the elapsed time in seconds.");
            while (!int.TryParse(Console.ReadLine(), out userSecond)) ;
                Console.WriteLine("Invalid Input. Please try again");

            Console.WriteLine($"Your Time in seconds is {userHour*3600+userMinute*60+userSecond}");

            Console.WriteLine();
        }//end of Problem4
        public static void Problem5()
        {
            Console.WriteLine("Problem 5");
            Console.WriteLine();
            //To make a profit, a local store marks up the prices of its items by a certain percentage. Write a program that reads the original price of the item sold, the percentage of the marked-up price, and the sales tax rate. The program then outputs the original price of the item, the percentage of the mark-up, the store’s selling price of the item, the sales tax rate, the sales tax, and the final price of the item. (The final price of the item is the selling price plus the sales tax.)
            double price, markup, tax;

            Console.WriteLine("What is the intial price of item");
            while (!double.TryParse(Console.ReadLine(), out price)) ;
                Console.WriteLine("Invalid Input. Please try again");

            Console.WriteLine("What is the mark up of item in decimal");
            while (!double.TryParse(Console.ReadLine(), out markup)) ;
                Console.WriteLine("Invalid Input. Please try again");

            Console.WriteLine("What is the sale tax of item in decimal");
            while (!double.TryParse(Console.ReadLine(), out tax)) ;
                Console.WriteLine("Invalid Input. Please try again");

            Console.WriteLine($"The total price is {(price*(1+markup)+price*tax).ToString("C")}");


            Console.WriteLine();
        }//end of Problem5
        public static void Problem6()
        {
            Console.WriteLine("Problem 6");
            Console.WriteLine();
            //Write a program that prompts the user to input a length expressed in centimeters. The program should then convert the length to inches (to the nearest inch) and output the length expressed in yards, feet, and inches, in that order. For example, suppose the input for centimeters is 312. To the nearest inch, 312 centimeters is equal to 123 inches. 123 inches would thus be output as: 3 yard(s), 1 feet(foot), and 3 inch(es).
            double cm, inches, foot, yard;

            Console.WriteLine("Please enter length in cm");
            while (!double.TryParse(Console.ReadLine(), out cm)) ;
                Console.WriteLine("Invalid Input. Please try again");

            inches = cm / 2.54;
            yard = Math.Floor(inches / 36);
            foot = Math.Floor((inches - (yard * 36)) / 12);
            inches = inches - (yard * 36) - (foot * 12);

            Console.WriteLine($"{cm}cm is {yard} yard, {foot} foot, {inches}");



            Console.WriteLine();
        }//end of Problem6
        public static void Problem7()
        {
            Console.WriteLine("Problem 7");
            Console.WriteLine();

            //A milk carton can hold 3.78 liters of milk. Each morning, a dairy farm ships cartons of milk to a local grocery store. The cost of producing one liter of milk is $0.38, and the profit of each carton of milk is $0.27. Write a program that does the following:

            //a.Prompts the user to enter the total amount of milk produced in the morning.

            //b.Outputs the number of milk cartons needed to hold milk. (Round your answer to the nearest integer.)

            //c.Outputs the cost of producing milk.

            //d.Outputs the profit for producing milk.

            int userMilk,cartonTotal;
            Console.WriteLine("Please enter the total amount of milk produced");
            while (!int.TryParse(Console.ReadLine(), out userMilk)) ;
                Console.WriteLine("Invalid Input. Please Try Again");

            cartonTotal = (int)Math.Floor(userMilk / 3.78);
            Console.WriteLine($"There is a total of {cartonTotal} milk cartons");

            Console.WriteLine($"The total cost of the milk production is ${(cartonTotal*.38).ToString("C")}");
            Console.WriteLine($"The total profit of the milk production is ${(cartonTotal * .27).ToString("C")}");


            Console.WriteLine();
        }//end of Problem7
    }//end of class
}//end of namespace
