// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int firstnum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondnum = Convert.ToInt32(Console.ReadLine());
int max;

if(firstnum > secondnum)
{
    max = firstnum;
    Console.WriteLine($"max = {firstnum} ");
}

else if(firstnum == secondnum)
{
    Console.WriteLine($"{firstnum} = {secondnum} ");
}

else
{
    max = secondnum;
    Console.WriteLine($"max = {secondnum} ");
}