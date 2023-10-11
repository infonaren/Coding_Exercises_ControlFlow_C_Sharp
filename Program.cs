using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises_ControlFlow_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
       Write a C# program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
       Display the count on the console.
       */

            var randomValues = new Random();
            var countMutiplesOfThree = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    countMutiplesOfThree++;
                }
            }
            Console.WriteLine(string.Format("The number of numbers between 1 and 100 divisible by 3 is: {0}", countMutiplesOfThree));

            /* 
            Write a C# program and continuously ask the user to enter a number or "ok" to exit. 
            Calculate the sum of all the previously entered numbers 
            and display it on the console.

             var isUserPrompt = true;
            var sumOfNumbers = 0;
            while (isUserPrompt)
            {
                Console.WriteLine("Enter a number (or) 'ok' to exit");
                var userInput = Console.ReadLine();
                if (userInput == "ok")
                {
                    isUserPrompt = false;
                    break;

                }
                else
                {
                    int number = Convert.ToInt32(userInput);
                    sumOfNumbers += number;
                }
            }
            Console.WriteLine("The sum of all the previously entered numbers: {0}",sumOfNumbers);
            */

            int sum = 0;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Enter a number or type 'ok' to exit:");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "ok")
                {
                    exit = true;
                }
                else
                {
                    if (int.TryParse(userInput, out int number))
                    {
                        sum += number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }

            Console.WriteLine($"The sum of all entered numbers is: {sum}");

            /*
             Write a program and ask the user to enter a number. 
             Compute the factorial of the number and print it on the console. 
             For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
             */

            Console.WriteLine("Enter the factorial number: ");

            var mulitplyNumber = 1;
            var factorialNumber = Convert.ToInt32(Console.ReadLine());

            for (var i = factorialNumber; i > 0; i--)
                mulitplyNumber *= i;

            Console.WriteLine(string.Format("The factorial of the number is: {0}", mulitplyNumber));


            /*
            Write a program that picks a random number between 1 and 10. 
            Give the user 4 chances to guess the number. 
            If the user guesses the number, display “You won"; otherwise, display “You lost". 
            (To make sure the program is behaving correctly, you can display the secret number on the console first. 
            */

            const int NumberOfChances = 4;
            var randomGuessNumber = new Random();
            var secretNumber = randomGuessNumber.Next(1, 10);
            Console.WriteLine(secretNumber);

            for (var i = NumberOfChances; i > 0; i--)
            {
                Console.WriteLine("You've got {0} chances to guess the correct number between 1 and 10", i);
                var guessNumber = Convert.ToInt32(Console.ReadLine());
                if (secretNumber == guessNumber)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else
                {
                    Console.WriteLine("You lost");
                }
            }

            /*
             Write a program and ask the user to enter a series of numbers separated by comma.
             Find the maximum of the numbers and display it on the console. 
             For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
             */

            Console.WriteLine("Please enter a series of numbers separated by comma: ");
            var numberSeries = Console.ReadLine();

            string[] numbers = numberSeries.Split(',');

            int max = int.MinValue;
            foreach (var number in numbers)
            {
                var currentNumber = int.Parse(number);
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            Console.WriteLine("The maximum number is: " + max);


        }
    }
}
