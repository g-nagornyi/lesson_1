Console.WriteLine("Введите любое целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = n * (-1);
while (count <= n)
{
    System.Console.WriteLine(count);
    count++;
}

