Console.WriteLine("Please provide you age: ");
string age = Console.ReadLine();
int intAge = int.Parse(age);
bool isChild = intAge >= 0 && intAge <= 12;
bool isTeenager = intAge >= 13 && intAge <= 19;
bool isAdult = intAge > 19;

Console.WriteLine($"You are a child: {isChild}\nYou are a teenager: {isTeenager}\nYou are adult: {isAdult}");