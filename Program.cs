void Z1 () 
{
Random dom = new Random();
int ent = dom.Next(1, 11);
int [] ray = new int [ent];
for (int i = 0; i<ent; i++) 
{
    Console.WriteLine("Введите " + $"{i+1}" + "число");
    int num = Convert.ToInt32(Console.ReadLine());
    ray[i] = num;
}
int count = 0;
Console.WriteLine("41. Из чисел ");
for (int i = 0; i<ent; i++) 
{
    if (ray[i] > 0) count++;
    Console.Write(ray[i] + ", ");
}
Console.Write("\b\b - " + count + " чисел больше нуля.");
}
Z1();

void Z2() 
{

}
Z2();