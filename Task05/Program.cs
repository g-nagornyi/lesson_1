Console.WriteLine("Введите любое целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = -n;
while (count <= n)
{
    System.Console.WriteLine(count);
    count++;
}

