﻿// Напишем программу, которая будет выводить день недели по заданному номеру.

using System.Collections.Specialized;

Console.WriteLine("Введите номер дня недели : ");
string dayNumber = Console.ReadLine();

if (dayNumber == "1")
{
    Console.WriteLine($"{dayNumber} -> Понедельник.");
}
else if (dayNumber == "2")
{
    Console.WriteLine($"{dayNumber} -> Вторник.");
}
else if (dayNumber == "3")
{
    Console.WriteLine($"{dayNumber} -> Среда.");
}
else if (dayNumber == "4")
{
    Console.WriteLine($"{dayNumber} -> Четверг.");
}
else if (dayNumber == "5")
{
    Console.WriteLine($"{dayNumber} -> Пятница.");
}
else if (dayNumber == "6")
{
    Console.WriteLine($"{dayNumber} -> Суббота.");
}
else if (dayNumber == "7")
{
    Console.WriteLine($"{dayNumber} -> Воскресенье.");
}
else 
{
    Console.WriteLine("Ошибка ввода!");
}