﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите любые два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a>b) {
    System.Console.WriteLine($"Число {a} больше, чем число {b}");
}
else if (a<b) {
    System.Console.WriteLine($"Число {b} больше, чем число {a}");
}
else {
    System.Console.WriteLine("Числа равны друг другу");
}
