int secondsInMinute = 60;
int minutesInHour = 60;
int hoursInDay = 24;

int secondsCalculated;
int minutesCalculated;
int hoursCalculated;
float daysCalculated;

float daysInFloat;

Console.WriteLine("Provide a number of seconds: ");
string input = Console.ReadLine();
int intInput = int.Parse(input);

CalculateTime(intInput);
PrintTime();

void CalculateTime(int secondsInput){
    int remainingSeconds = secondsInput;

    daysInFloat = (float)secondsInput / ((float)hoursInDay * (float)minutesInHour * (float)secondsInMinute);

    daysCalculated = secondsInput / (hoursInDay * minutesInHour * secondsInMinute);
    remainingSeconds %= secondsInput = (hoursInDay * minutesInHour * secondsInMinute);

    hoursCalculated = remainingSeconds / (minutesInHour * secondsInMinute);
    remainingSeconds %= (minutesInHour * secondsInMinute);

    minutesCalculated = remainingSeconds / secondsInMinute;
    
    secondsCalculated = remainingSeconds % secondsInMinute;
}

void PrintTime(){
    Console.WriteLine("Seconds: " + secondsCalculated);
    Console.WriteLine("Minutes: " + minutesCalculated);
    Console.WriteLine("Hours: " + hoursCalculated);
    Console.WriteLine("Days " + daysCalculated);
    Console.WriteLine($"{daysCalculated}.{hoursCalculated}:{minutesCalculated}:{secondsCalculated}");
    Console.WriteLine($"In total, thats: {daysInFloat} days!");
}