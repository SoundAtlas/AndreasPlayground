// See https://aka.ms/new-console-template for more information

//Fizzbuzz game

/*Console.WriteLine("Welcome to the FizzBuzz game!");


static string fizzBuzz(int number)
{
    if (number % 3 == 0 && number % 5 == 0)
        return "FizzBuzz";
    else if (number % 3 == 0)
        return "Fizz";
    else if (number % 5 == 0)
        return "Buzz";
    else
        return number.ToString();
}

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(fizzBuzz(i));
}*/





//MenuTutorial

/*using System;

namespace MenuTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the new intro method
            ShowWelcome();

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n--- HOVEDMENU ---");
                Console.WriteLine("1) Introduktion");
                Console.WriteLine("2) Lav en beregning");
                Console.WriteLine("3) Afslut");
                Console.Write("\nVælg en mulighed: ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowIntro();
                        break;
                    case "2":
                        PerformCalculation();
                        break;
                    case "3":
                        isRunning = false;
                        Console.WriteLine("Programmet afsluttes...");
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen.");
                        break;
                }
            }
        }

        static void ShowWelcome()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================================");
            Console.WriteLine("    VELKOMMEN TIL MIN SOFTWARE TUTORIAL   ");
            Console.WriteLine("==========================================");
            Console.ResetColor();
            Console.WriteLine("\nTryk på en tast for at starte...");
            Console.ReadKey();
        }

        static void ShowIntro()
        {
            Console.WriteLine("\nDette program lærer dig at bruge switch-statements og loops i C#.");
        }

        static void PerformCalculation()
        {
            try
            {
                Console.Write("Indtast tal A: ");
                double numberA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Indtast tal B: ");
                double numberB = Convert.ToDouble(Console.ReadLine());

                double result = numberA + numberB;
                Console.WriteLine($"Resultatet af {numberA} + {numberB} er: {result}");
            }
            catch (Exception)
            {
                Console.WriteLine("Fejl: Indtast venligst et gyldigt tal.");
            }
        }
    }
}
*/

/*bool isValid;

do
{
    isValid = true;

    Console.Write("Write a number\n> ");
  



    try
    {
        int userInput = int.Parse(Console.ReadLine());
        Console.WriteLine($"Wow you completed the task and wrote {userInput} which is a valid number");
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid input, please write a number");
        isValid = false;
    }
}
while (!isValid);*/







// 1. Input + validation "safe number reader"

/*Console.WriteLine("Enter an integer between 1-10: ");

int userInput = 0;

bool isValid = false;

do
{
    try
    {
        userInput = int.Parse(Console.ReadLine());
        if (userInput < 1 || userInput > 10)
        {
            Console.WriteLine("Invalid input, please enter a number between 1 and 10.");
            isValid = false;
        }
        else         
        {
            Console.WriteLine($"You entered {userInput}, which is a valid number.");
            isValid = true;
        }
    }

    catch (FormatException)
    {
        Console.WriteLine("Invalid input, please enter a valid integer.");
        isValid = false;
    }
} while (!isValid);*/


//2. Method Practice "Menu + Simple Calculator"

bool isRunning = true;

while (isRunning)
{
    Console.Clear();
    Console.WriteLine("====== MAIN MENU ======");
    Console.WriteLine("  ---  CALCULATOR  --- ");
    Console.WriteLine("1) Add");
    Console.WriteLine("2) Subtract");
    Console.WriteLine("3) Multiply");
    Console.WriteLine("4) Divide");
    Console.WriteLine("5) Exit");
    Console.WriteLine("=======================");
    Console.Write("Choose an option:\n>");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("You chose '1) Add'");
            break;
        case 2:
            Console.WriteLine("You chose '2) Subtract'");
            break;
        case 3:
            Console.WriteLine("You chose '3) Multiply'");
            break;
        case 4:
            Console.WriteLine("You chose '4) Divide'");
            break;
        case 5:
            isRunning = false;
            break;
    }
        
}