void DZ1 () 
{
Random dom = new Random();
int ent = dom.Next(1, 11);
int [] ray = new int [ent];
for (int i = 0; i<ent; i++) 
{
    Console.WriteLine("Введите " + $"{i+1}" + " число:");
    int num = Convert.ToInt32(Console.ReadLine());
    ray[i] = num;
}
int count = 0;
Console.WriteLine();
Console.Write("41. Из чисел ");
for (int i = 0; i<ent; i++) 
{
    if (ray[i] > 0) count++;
    Console.Write(ray[i] + ", ");
}
if (count>4) Console.Write("\b\b - " + count + " чисел больше нуля.");
else Console.Write("\b\b - " + count + " числа больше нуля.");
}

void DZ2() 
{

}

DZ1();
DZ2();