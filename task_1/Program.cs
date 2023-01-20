// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
// int number=23432;

int count;
int count_1;
int number1;
// Console.WriteLine(number/100%10);

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
        while (number1==number/100%10)
        {
            count=number/100;
            Console.WriteLine($"Count {count}");
            count_1=number%10;
            Console.WriteLine($"Count_1 {count_1}");
            if (count==count_1)
            {
                number=number%10/10;
                Console.WriteLine(number);
            }
            else 
            {   
                Console.WriteLine($"Введенное число {number} не является палиндромом");
                break;
            }
        }
    }
}