Console.Write("Введите число");

int a = int.Parse(Console.ReadLine());

for (int b = 1; b <= a; b++)
    if (b % 2 == 0)
        Console.WriteLine(b);