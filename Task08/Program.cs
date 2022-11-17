/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n % 2;
int count = 2;
if (a == 0)
{
    while (count <= n)
    {
        System.Console.WriteLine(count);
        count = count + 2;
    }
}
else
{
    while (count < n)
    {
        System.Console.WriteLine(count);
        count = count + 2;
    }
}

