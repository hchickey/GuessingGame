using System;

Main();

void Main()
{
    Console.WriteLine("Guess the Secret Number!");

    Random num = new Random();
    int secretNumber = num.Next(1, 100);
    multipleChances(4, secretNumber);

}

int GetUserGuess()
{
    Console.Write("Enter a number (1-100): ");
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
        Console.WriteLine($"You have {numberOfChances - i} guesses left");
        int userGuess = GetUserGuess();
        isSecretNumber(userGuess, secretNumber);

        if (secretNumber < userGuess)
        {
            Console.WriteLine("Your guess was too high");
        }
        else if (secretNumber > userGuess)
        {
            Console.WriteLine("Your guess was too low");
        }

        if (secretNumber == userGuess)
        {
            break;
        }

        if (i == numberOfChances - 1)
        {
            Console.WriteLine($"Sorry ran out of guesses! The answer is {secretNumber}");
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