Random myNumber = new Random();
int randomInt = myNumber.Next(1, 101);
int answer;

Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");

do
{
    Console.Write("Enter your guess: ");
    answer = int.Parse(Console.ReadLine());

    if (answer < randomInt)
    {
        Console.WriteLine("My number is greater!");
    }
    else if (answer > randomInt)
    {
        Console.WriteLine("My number is smaller!");
    }
    else if (answer == randomInt)
    {
        Console.WriteLine("Correct! You've guessed the number!");
    }
} 
while (answer != randomInt);
