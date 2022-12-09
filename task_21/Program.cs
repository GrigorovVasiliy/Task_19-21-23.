Console.Clear();
Console.Write("Введите кординату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2)),2));
