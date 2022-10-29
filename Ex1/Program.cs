// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

int ost10 = 0;
int res = 0;

if (num > 99 && num < 1000) 
    {
    ost10 = num / 10;
    res = ost10 % 10;
    System.Console.WriteLine($"{num} -> {res}");
    }
else {
    System.Console.WriteLine("Число не является трехзначным");
    }