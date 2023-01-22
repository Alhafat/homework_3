// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();

// while (true)
// {
//     Console.Write("Введите любое число: ");
//     int number=int.Parse(Console.ReadLine()!);
//     if ((number/10000)<1) 
//     {
//         Console.WriteLine($"Запрашиваемое число введено неверно, попробуйте еще раз!");
//         continue;
//     }
//     else
//     {
//         int result=number;
//         int count;
//         int number1=0;
//         while (number>0)
//         {
//             count=number%10;
//             number1=number1*10+count;
//             number=number/10;
//         }
//         if (result==number1)
//         {
//             Console.WriteLine($"Введенное число {result} является палиндромом");
//             break;
//         }
//         else
//         {
//             Console.WriteLine($"Введенное число {result} не является палиндромом");
//             break;
//         }
//     }
// }


        
Console.Write("Введите любое число: ");
int number=int.Parse(Console.ReadLine()!);
int result=number;
int count=0;
int numberLast=0;
int numberFirst=0;

while (number>0)
{
    numberLast=number%10;
    Console.WriteLine($"numberLast: {numberLast}");
    int digits=number;
    while (digits>0)
    {
        numberFirst=digits; 
        digits=digits/10;
        count++;
        // Console.WriteLine($"count: {count}");
        // Console.WriteLine($"numberFirst: {numberFirst}");
    }
    // break;
    count-=1;
    // Console.WriteLine($"count: {count}");
    // Console.WriteLine($"numberFirst: {numberFirst}");
    if (numberFirst==numberLast)
    {
        number=number-numberFirst*Convert.ToInt32(Math.Pow(10,count));  //убрали первую цифру
        // number=number-numberFirst*Math.Pow(10,count);                   //убрали первую цифру
        number=number/10;                                               // убрали вторую цифру
        // Console.WriteLine($"number: {number}"); 
    }
    else
    {
        Console.WriteLine($"Введенное число {result} не является палиндромом");
        break;
    }
}
if (numberFirst==numberLast) Console.WriteLine($"Введенное число {result} является палиндромом");