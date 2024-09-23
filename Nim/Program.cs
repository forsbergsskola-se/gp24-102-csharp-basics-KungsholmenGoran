int remainingMatches = 24;
string playerString;

gameLoop();

void playerTurn()
{
    playerString = "Player";
    Console.WriteLine("Remaining matches: ");

    for (int i = 0; i < remainingMatches; i++)
    {
        Console.Write("|");
    }

    Console.WriteLine("\nHow many matches do you draw?\nYour input: ");
    int playerDraw = int.Parse(Console.ReadLine());

    if (playerDraw >= 1 && playerDraw <= 3)
    {
        remainingMatches -= playerDraw;
    }
    else
    {
        Console.WriteLine("Invalid input, choose a number between 1-3");
        playerTurn();
    }
}

void aiTurn() // impossible to beat
{
    playerString = "AI";
    Random random = new Random();
    int aiDraw = random.Next(1, 4);

    if (remainingMatches == 7){
        remainingMatches = remainingMatches - 1;
        Console.WriteLine($"AI draws: 1");
    }
    else if (remainingMatches == 6)
    {
        remainingMatches = remainingMatches - 1;
        Console.WriteLine($"AI draws: 1");
    }
    else if (remainingMatches == 5){
        remainingMatches = remainingMatches - 1;
        Console.WriteLine($"AI draws: 1");
    }
    else if (remainingMatches == 4){
        remainingMatches = remainingMatches - 1;
        Console.WriteLine($"AI draws: 1");
    }
    else if (remainingMatches == 3){
        remainingMatches = remainingMatches - 2;
        Console.WriteLine($"AI draws: 2");
    }
      else if (remainingMatches == 2){
        remainingMatches = remainingMatches - 1;
        Console.WriteLine($"AI draws: 1");
    }
    else
    {
        remainingMatches -= aiDraw;
        Console.WriteLine($"AI draws: {aiDraw}");
    }


}

void gameLoop()
{
    while (remainingMatches > 0)
    {
        playerTurn();
        if (remainingMatches <= 0)
        {
            Console.WriteLine($"{playerString} loses");
            break;
        }

        aiTurn();
        if (remainingMatches <= 0)
        {
            Console.WriteLine($"{playerString} loses");
            break;
        }
    }
}
