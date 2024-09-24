using System.Threading.Channels;

Random random = new Random();
int chance = random.Next(101);

if (chance <= 10){
    Console.WriteLine("This is a secret message");
}
else{
    Console.WriteLine("Try again");
}