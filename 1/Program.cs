using System;

double GetNumber(string message){
    Console.WriteLine(message);
    return double.Parse(Console.ReadLine());
}

bool Validate(double exp){
    if(exp < 0)
    {
        Console.WriteLine("Нужна степень больше нуля");
        return false;
    }
    return true;
}

double number = GetNumber("Введите число:");
double exp = GetNumber("Введите степень:");
bool canExp = Validate(exp);
if(canExp)
{
    Console.WriteLine(Math.Pow(number, exp));
}

