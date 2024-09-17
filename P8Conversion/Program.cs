string question = "Please provide a number: ";
Console.WriteLine(question);
string input = Console.ReadLine();

float floatValue = float.Parse(input);
Console.WriteLine(floatValue);
int intValue = (int)floatValue;
Console.WriteLine(intValue);
/*int intTryConvert = int.Parse(question);
Console.WriteLine(intTryConvert);*/