Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()), i;

for(i = 1; i<=a; i++)
    Console.Write($"{i*i*i}; ");