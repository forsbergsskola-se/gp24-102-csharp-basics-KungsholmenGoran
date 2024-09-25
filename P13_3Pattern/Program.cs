// not sure if I am to use count <= input

Console.WriteLine("Enter a number: ");
int input = int.Parse(Console.ReadLine());
int count = 0;

label1:
if (count < input)
{
    Console.WriteLine();
    for (int i = 0; i < input; i++)
    {
        Console.Write("#-");
    }
    count++;
}
if (count < input)
{
    Console.WriteLine();
    for (int o = 0; o < input; o++)
    {
        Console.Write("-#");
    }
    count++;
    goto label1;
}