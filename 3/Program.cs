using System;

int GetNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int[] GenerateArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    Random rand = new Random();
    for(int i = 0; i < Length; i++)
    {
        array[i] = rand.Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length -1; i++){
        Console.Write(array[i]);
        Console.Write(",");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

int length = GetNumber("Введите длину массива");
int min = GetNumber("Минимальное число:");
int max= GetNumber("Максимальное число:");
int[] array = GenerateArray(length, min, max);
PrintArray(array);