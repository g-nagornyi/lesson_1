Console.WriteLine("Введите любое трехначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)
{
    number = number % 10;
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}

