// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите любое число: ");
int number=int.Parse(Console.ReadLine()!);

int count=1;

while (count<=number)
{
    Console.Write($"{Math.Pow(count,3)}");
    if (count!=number)  Console.Write(", "); //выводит запятую после каждой цифры 
    count++;
}