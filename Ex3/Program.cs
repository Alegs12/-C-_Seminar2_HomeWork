// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите цифру, обозначающую день недели ");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
        System.Console.WriteLine($"{num} -> нет, поднедельник - не выходной");
        break;
    case 2:
        System.Console.WriteLine($"{num} -> нет, вторник - не выходной");
        break;
    case 3:
        System.Console.WriteLine($"{num} -> нет, среда - не выходной");
        break;
    case 4:
        System.Console.WriteLine($"{num} -> нет, четверг - не выходной");
        break;
    case 5:
        System.Console.WriteLine($"{num} -> нет, пятница - не выходной");
        break;
    case 6:
        System.Console.WriteLine($"{num} -> да, суббота - выходной");
        break;
    case 7:
        System.Console.WriteLine($"{num} -> да, воскресенье - выходной");
        break;
    default:
        System.Console.WriteLine("Нужно ввести число от 1 до 7");
        break;
}