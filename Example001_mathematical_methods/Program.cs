// Написать программу, которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.

using System.Collections.Specialized;

Console.WriteLine("Введите первое число : ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число : ");
int numB = Convert.ToInt32(Console.ReadLine());

if(numA == numB * numB){
    Console.WriteLine("Условие выполнено.");
}
else{
    Console.WriteLine("Не верно, попробуйте ещё раз.");
}
