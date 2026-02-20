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
    Console.Write("Choose an option:\n> ");

    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine("Invalid option, please enter a number between 1-5");
        Pause();
        continue;
    }

    switch (choice)
    {
        case 1:
            Console.WriteLine("1) Add");
            Add();
            Pause();
            break;
        case 2:
            Console.WriteLine("2) Subtract");
            Subtract();
            Pause();
            break;
        case 3:
            Console.WriteLine("3) Multiply");
            Multiply();
            Pause();
            break;
        case 4:
            Console.WriteLine("4) Divide");
            Divide();
            Pause();
            break;
        case 5:
            isRunning = false;
            Console.WriteLine("Thank you for using the calculator, have a great day!");
            break;
        default:
            Console.WriteLine("Invalid input, please enter a number between 1-5!");
            Pause();
            break;
    }



    void Pause()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
        
    void Add()
    {
        bool addRunning = false;

        do
        {            
            Console.Write("\nChoose first number:\n> ");
            string numInput1 = Console.ReadLine();
            double num1 = 0;
            bool success1 = double.TryParse(numInput1, out num1);

            if (success1)
            {
                Console.Write("\nChoose second number:\n> ");
                String numInput2 = Console.ReadLine();
                double num2 = 0;
                bool success2 = double.TryParse(numInput2, out num2);

                if (success2)
                {
                    double result = num1 + num2;
                    Console.WriteLine($"The result of {num1:F2} + {num2:F2} is: {result:F2}");
                    addRunning = true;
                }
                else
                {
                    Console.WriteLine("Error: You must enter number only!");
                    addRunning = false;
                }

            }
            else
            {
                Console.WriteLine("Error: You must enter numbers only!");
                addRunning = false;
            }

        }
        while(!addRunning);
        
    }

    void Subtract()
    {
        bool subtractRunning = false;

        do
        {
            Console.Write("\nChoose first number:\n> ");
            string numInput1 = Console.ReadLine();
            double num1 = 0;
            bool success1 = double.TryParse(numInput1, out num1);

            if (success1)
            {
                Console.Write("\nChoose second number:\n>");
                String numInput2 = Console.ReadLine();
                double num2 = 0;
                bool success2 = double.TryParse(numInput2, out num2);
                
                if (success2)
                {
                    double result = num1 - num2;
                    Console.WriteLine($"The result of {num1:F2} - {num2:F2} is: {result:F2}");
                    subtractRunning = true;
                }
                else
                {
                    Console.WriteLine("Error: You must enter numbers only!");
                    subtractRunning = false;
                }
            }
            else
            {
                Console.WriteLine("Error: You must enter numbers only!");
                subtractRunning = false;
            }
        }
        while (!subtractRunning);
    }

    void Multiply()
    {

        bool multiplyRunning = false;

        do
        {

            Console.Write("\nChoose first number:\n> ");
            string numInput1 = Console.ReadLine();
            double num1 = 0;
            bool success1 = double.TryParse(numInput1, out num1);

            if (success1)
            {
                Console.Write("\nChoose second number:\n> ");
                string numInput2 = Console.ReadLine();
                double num2 = 0;
                bool success2 = double.TryParse(numInput2, out num2);
                
                if (success2)
                {
                    double result = num1 * num2;
                    Console.WriteLine($"The result of {num1:F2} * {num2:F2} is: {result:F2}");
                    multiplyRunning = true;

                }
                else
                {
                    Console.WriteLine("Error: You must enter numbers only!");
                    multiplyRunning = false;
                }
            }

            else
            {
                Console.WriteLine("Error: You must enter numbers only!");
                multiplyRunning = false;
            }
        }
        while (!multiplyRunning);
    }

    void Divide()
    {
        bool divideRunning = false;
        {
            do
            {

                Console.Write("\nCho0se first number:\n> ");
                string numInput1 = Console.ReadLine();
                double num1 = 0;
                bool success1 = double.TryParse(numInput1, out num1);

                if (success1)
                {
                    
                        Console.Write("\nChoose second number:\n> ");
                        string numInput2 = Console.ReadLine();
                        double num2;
                        bool success2 = double.TryParse(numInput2, out num2);
                        
                        if (success2)
                        {
                            if (num2 != 0)
                            {
                                double result = num1 / num2;
                                Console.WriteLine($"The result of {num1:F2} / {num2:F2} is: {result:F2}");
                                divideRunning = true;

                            }
                            else
                            {
                                Console.WriteLine("Error: Division by 0 is not allowed!");
                                divideRunning = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: You must enter numbers only!");
                            divideRunning = false;
                        }
                    
                }
                else
                {
                    Console.WriteLine("Error: You must enter numbers only!");
                    divideRunning = false;
                }
                
            }
            while (!divideRunning); 
        }
    }
}