using System;

Main();

void Main()
{
    Console.WriteLine("Guess the Secret Number!");

    int secretNumber = 42;

    multipleChances(4, secretNumber);

}

int GetUserGuess()
{
    Console.Write("Enter a number: ");
    int userGuess = int.Parse(Console.ReadLine());

    return userGuess;
}

// void UserDisplaysAnswer(int userGuess)
// {
//     Console.WriteLine($"You guessed {userGuess}");
// }

void multipleChances(int numberOfChances, int secretNumber)
{
    for (int i = 0; i < numberOfChances; i++)
    {
        Console.WriteLine($"Guess number {i + 1}");
        int userGuess = GetUserGuess();
        isSecretNumber(userGuess, secretNumber);

        if (secretNumber == userGuess)
        {
            break;
        }

        if (i == numberOfChances - 1)
        {
            Console.WriteLine("Sorry ran out of guesses!");
        }
    }


}

void isSecretNumber(int userGuess, int secretNumber)
{

    if (userGuess == secretNumber)
    {
        Console.WriteLine("You guessed the secret number!");
    }
    else
    {
        Console.WriteLine("You guessed incorrectly");
    }
}