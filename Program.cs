void DZ1 () 
{
Random dom = new Random();
int ent = dom.Next(1, 11);
int [] ray = new int [ent];
Console.WriteLine("Вы можете ввести значение " + ent + " раз.");
for (int i = 0; i<ent; i++) 
{
    Console.WriteLine("Введите " + $"{i+1}" + " число:");
    int num = Convert.ToInt32(Console.ReadLine());
    ray[i] = num;
}
int count = 0;
Console.WriteLine();
Console.Write("41. Из чисел: ");
for (int i = 0; i<ent; i++) 
{
    if (ray[i] > 0) count++;
    Console.Write(ray[i] + ", ");
}
if (count>4) Console.Write("\b\b — " + count + " чисел больше нуля.");
else Console.Write("\b\b — " + count + " числа больше нуля.");
}

void DZ2() 
{
Console.WriteLine("43. Введите значения двух прямых: ");
double  b1 = Convert.ToInt32(Console.ReadLine()),
        k1 = Convert.ToInt32(Console.ReadLine()),
        b2 = Convert.ToInt32(Console.ReadLine()),
        k2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2) Console.WriteLine("Заданные прямые параллельны.");
else 
{
    double x = Math.Round((b2 - b1)/(k1-k2), 2);
    double y = Math.Round(k1*(b2 - b1)/(k1-k2)+b1, 2);
    Console.WriteLine("Заданные прямые пересекаются в точке (" + x + ", " + y + ")");
}
}

//DZ1();
DZ2();