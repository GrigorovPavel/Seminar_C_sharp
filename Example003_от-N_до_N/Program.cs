// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());
int count = -1 * n;

while (count <= n)
{
    Console.Write($"{count}, ");
    count = count +1;
}
