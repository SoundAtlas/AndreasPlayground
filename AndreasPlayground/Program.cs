
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
/*
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

    int choice = ReadInt("Choose an option:\n> ",1 ,5);

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
            Console.WriteLine("Thank you for using the calculator, have a great day!");
            Pause();
            isRunning = false;
            break;
        default:
            Console.WriteLine("Invalid input, please enter a number between 1-5!");
            Pause();
            break;
    }

}
    void Pause()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
        
    void Add()
    {
                 
        double num1 = ReadDouble("\nChoose first number:\n> ");
        double num2 = ReadDouble("\nChoose second number:\n> ");                 
              
        double result = num1 + num2;
        Console.WriteLine($"The result of {num1:F2} + {num2:F2} is: {result:F2}");                              
        
    }

    void Subtract()
    {

        double num1 = ReadDouble("\nChoose first number:\n> ");
        double num2 = ReadDouble("\nChoose second number:\n> ");

        double result = num1 - num2;
        Console.WriteLine($"The result of {num1:F2} - {num2:F2} is: {result:F2}");

    }       

    void Multiply()
    {           
        double num1 = ReadDouble("\nChoose first number:\n> ");
        double num2 = ReadDouble("\nChoose second number:\n> ");

        double result = num1 * num2;
        Console.WriteLine($"The result of {num1:F2} * {num2:F2} is: {result:F2}");
        
    }

    void Divide()
    {
                        
        double num1 = ReadDouble("\nChoose first number:\n> ");
        double num2 = ReadNonZeroDouble("\nChoose second number:\n> ");

        double result = num1 / num2;
        Console.WriteLine($"The result of {num1:F2} / {num2:F2} is: {result:F2}");
                
    }


    int ReadInt(string message, int min, int max)
    {
        while (true)
        {
            Console.Write(message);

            if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
                return value;
                      
                Console.WriteLine($"Invalid input. Please enter a whole number between {min}-{max}.");
        }
    }

    double ReadDouble(string message)
    {
        while (true)
        {
            Console.Write(message);

            if (double.TryParse(Console.ReadLine(), out double value))
                return value;

            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    double ReadNonZeroDouble(string message)
    {
        while (true)
        {

            double value = ReadDouble(message);

            if (value != 0)            
                return value;

            Console.WriteLine("Error: Division by 0 is not allowed!");           

        }
    }

*/




//3. Guess the Number 2.0

/*
Random rng = new Random();

int answer = MakeRandom();

Console.Write("\nA random number has been generated between 1-100. Try to guess it in as few guesses as possible\n> ");

int i = 0;

while (true)
{
 
    if (!int.TryParse(Console.ReadLine(), out int guess))
    {
        Console.WriteLine("Invalid input, please enter a valid integer.");
        Console.Write("> ");
        continue;
    }

    i++;
    if (guess == answer)
    {
        WinMessage(i);
        string resume;
        while (true)
        {
            Console.Write("Do you want to play again? (y/n)\n> ");
            resume = (Console.ReadLine() ?? "").Trim().ToLower();
            if (resume == "y" || resume == "n")
                break;

            Console.WriteLine("Please enter only 'y' or 'n'.");
        }


        if (resume == "y")
        {
            answer = MakeRandom();
            i = 0;
            Console.Write("\nA new random number has been generated between 1-100. Try to guess it in as few guesses as possible\n> ");
            continue;
        }
        else
        {
            Console.WriteLine("Thanks for playing! Goodbye!");
            break;

        }
    }
    else if (guess < answer)
        Console.WriteLine($"Too low! Try again.\nGuesses: {i}\n> ");

    else
        Console.Write($"Too high! Try again.\nGuesses: {i}\n> ");        
}

int MakeRandom()
{
    return rng.Next(1, 101);
}


void WinMessage(int guesses)
{
    if (guesses <= 5)
        Console.WriteLine($"You guessed correctly in {guesses} guesses. Good job, you are very sharp!");
    else if (guesses > 5 && guesses <= 10)
        Console.WriteLine($"You guessed correctly in {guesses} guesses. Good job");
    else
        Console.WriteLine($"You guessed correctly in {guesses} guesses.");
       
}
*/

//Exercise 4 — Palindrome Checker (Text + Number)


/*bool isRunning = true;

while (isRunning)
{
    Console.Clear();
    Console.WriteLine("=== WELCOME TO THE PALINDROME CHECKER ===");
    Console.WriteLine("         Please choose an option         ");

    Console.WriteLine("1) Check palindrome (text)");
    Console.WriteLine("2) Check palindrome (number)");
    Console.WriteLine("3) Exit");

    int choice = ReadInt("Choose an option:\n> ");

    switch (choice)
    {
        case 1:            
            CheckPalindromeText();
            Pause();
            break;
        case 2:            
            CheckPalindromeNumber();
            Pause();
            break;
        case 3:
            Console.WriteLine("Thank you for using the Palindrome Checker, have a great day!");
            Pause();
            isRunning = false;
            break;
        default:
            Console.WriteLine("Invalid input, please enter a number between 1-3!");
            Pause();
            break;
        }
    }



int ReadInt(string message)
{
       while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int value))
            return value;
        Console.WriteLine($"Invalid input. Please enter a whole number.");
    }

}



string ReadString(string message)
{
    
    Console.Write(message);
    return Console.ReadLine() ?? "";

}

void Pause()
{
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}


void CheckPalindromeText()
{
    string original;

    while (true)
    {
        original = ReadString("Enter a text to check if it's a palindrome:\n> ");

        if (!string.IsNullOrEmpty(original))
            break;

        Console.WriteLine("You must enter text.");

    }

    string cleaned = original.Replace(" ", "").ToLower();

    if (IsPalindrome(cleaned))
        Console.WriteLine($"'{cleaned}' is a palindrome");
    else
        Console.WriteLine($"'{cleaned}' is not a palindrome");
}

void CheckPalindromeNumber()
{
    int number = ReadInt("Enter a number to check if it's a palindrome:\n> ");

    string numberString = number.ToString();
    
    if (IsPalindrome(numberString))
        Console.WriteLine($"'{number}' is a palindrome.");
    else
        Console.WriteLine($"'{number}' is not a palindrome");





}

bool IsPalindrome(string text)
{



    int left = 0;
    int right = text.Length - 1;


    while (left < right)
    {
        if (text[left] != text[right])    
            return false;
        
        left++;
        right--;
    }

    return true;

}*/





// Karakter skala

/*
int score = ReadInt("Indtast score (0-100):\n> ");


if (ErGyldigScore(score))
{
    int karakter = BeregnKarakter(score);
    Console.WriteLine($"Karakter: {karakter}");
}
else
{
    Console.WriteLine("Ugyldig score. Score skal være mellem 0 og 100.");
}

bool ErGyldigScore(int score)
{
    return score >= 0 && score <= 100;
}

int BeregnKarakter(int score)
{
    if (score >= 90)
        return 12;
    else if (score >= 80)
        return 10;
    else if (score >= 65)
        return 7;
    else if (score >= 50)
        return 4;
    else if (score >= 25)
        return 2;
    else if (score >= 10)
        return 0;
    else
        return -3;
}


int ReadInt(string message)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int value)) 
            return value;

        Console.WriteLine($"Invalid input. Please enter a whole number.");
    }

}
*/





// Primenumberchecker
/*
Console.Write("Find alle primtal op til: ");
int n = int.Parse(Console.ReadLine());

for (int i = 2; i <= n; i++)
{
    if (ErPrimtal(i))
    {
        Console.WriteLine(i);
    }
}

bool ErPrimtal(int tal)
{
    if (tal <= 1)
        return false;

    for (int i = 2; i < Math.Sqrt(tal); i++)
    {
        if (tal % i == 0)
            return false;
    }
    
        return true;
}
*/



































