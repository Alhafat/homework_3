// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();

while (true)
{
    Console.Write("Введите любое число: ");
    int number=int.Parse(Console.ReadLine()!);
    if ((number/10000)<1) 
    {
        Console.WriteLine($"Запрашиваемое число введено неверно, попробуйте еще раз!");
        continue;
    }
    else
    {
        int result=number;
        int count;
        int number1=0;
        while (number>0)
        {
            count=number%10;
            number1=number1*10+count;
            number=number/10;
        }
        if (result==number1)
        {
            Console.WriteLine($"Введенное число {result} является палиндромом");
            break;
        }
        else
        {
            Console.WriteLine($"Введенное число {result} не является палиндромом");
            break;
        }
    }
}