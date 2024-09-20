Console.WriteLine("Whats your age? ");
int age = int.Parse(Console.ReadLine());
if (age >= 0 && age <= 12 ){
    Console.WriteLine("You are a child");
}
else if (age >=13 && age <= 17){
    Console.WriteLine("You are a teenager");
}
else if (age >= 18 && age <= 130){
    Console.WriteLine("You are an adult");
}
else {
    Console.WriteLine("Invalid input");
}
Console.WriteLine("Give me another integer: ");
int anotherInt = int.Parse(Console.ReadLine());
int max = (age > anotherInt) ? age : anotherInt;
Console.WriteLine("The maximum is: " + max);
string evenOrOdd = (max % 2 == 0) ? "That's a even number": "That's an odd number";
Console.WriteLine(evenOrOdd);