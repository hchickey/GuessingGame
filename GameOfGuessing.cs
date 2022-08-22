using System;

Main();

void Main()
{
    Console.WriteLine("Guess the Secret Number!");
    int userGuess = GetUserGuess();
    UserDisplaysAnswer(userGuess);
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