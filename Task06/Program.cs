﻿/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number % 2;
if (a == 0)
{
    System.Console.WriteLine($"Число {number} является чётным");
}
else
{
    System.Console.WriteLine($"Число {number} не является чётным");
}
