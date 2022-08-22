using System;

Main();

void Main()
{
    Console.WriteLine("Guess the Secret Number!");
    int userGuess = GetUserGuess();

    int secretNumber = 42;

    if (userGuess == secretNumber)
    {
        Console.WriteLine("You guessed the secret number!");
    }
    else
    {
        Console.WriteLine("You guessed incorrectly");
    }
}

int GetUserGuess()
{
    Console.Write("Enter a number: ");
    int userGuess = int.Parse(Console.ReadLine());

    return userGuess;
}

void UserDisplaysAnswer(int userGuess)
{
    Console.WriteLine($"You guessed {userGuess}");
}