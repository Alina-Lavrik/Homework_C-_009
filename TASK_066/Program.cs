/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.WriteLine("Введите число M: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int num2 = int.Parse(Console.ReadLine());

int SumNum(int num1, int num2)
{
    if (num1 >= num2) return num1;
    return SumNum(num1 + 1, num2) + num1;                                         

}
Console.WriteLine(SumNum(num1, num2));