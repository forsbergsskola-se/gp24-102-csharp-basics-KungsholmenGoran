Console.WriteLine("Please pass me a seed (integer): ");
int seed = int.Parse(Console.ReadLine());
Random random = new Random(seed);

Console.WriteLine("Three integers between 0 and 5: ");
for (int i = 0; i<3; i++){
    int randomInt = random.Next(0,5);
    Console.WriteLine(randomInt);
}
Console.WriteLine("Three numbers between 0.0 and 0.5: ");
for (int i = 0; i<3; i++){
    double randomDouble = random.NextDouble() * 0.5;
    Console.WriteLine(randomDouble);
}
Console.WriteLine("Three numbers between 0.2 and 0.7: ");
for (int i = 0; i<3; i++){
    double randomDouble2 = 0.2 + random.NextDouble() * 0.5;
    Console.WriteLine(randomDouble2);
}
Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%) ");
double critChance = double.Parse(Console.ReadLine());

Console.WriteLine("Simulating 5 attacks...");
for(int i = 0; i < 5; i++){
    double roll = random.NextDouble();
    string result = (roll < critChance) ? "Crit" : "No Crit";
    Console.WriteLine(result);
}