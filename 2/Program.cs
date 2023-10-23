int GetNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

bool Validate(int num){
    if(num < 0)
    {
        Console.WriteLine("Нужно ввести число больше нуля");
        return false;
    }
    return true;
}

int SumNumsInNumber(int number){
    int sum = 0;
    while(number > 0){
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int num = GetNumber("Введите число:");
bool canSum = validate(num);
if(canSum){
    Console.WriteLine(SumNumsInNumber(num));
}