void Z () 
{
Console.WriteLine("1. ");
string [,] table = new string[2, 5];
table[1, 2] = "cсло";
for (int rows = 0; rows < 2; rows++) 
{
    for (int col = 0; col < 5; col++) 
    {
        Console.Write($"{table[rows, col]} ");
    }
    Console.WriteLine("");
}
}
//Z();
void Z1 () 
{
Console.WriteLine("Введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine()), 
    b = Convert.ToInt32(Console.ReadLine()), 
    c = Convert.ToInt32(Console.ReadLine());
if (a+b<c || a+c<b || b+c<a) Console.WriteLine("Данный треугольник abc несуществует");
else Console.WriteLine("Данный треугольник abc существует");
}
//Z1();

void Z2() 
{
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()), ani = num, bni = ani, cni = num/2;
if (ani>0) 
{
    ani /= 2;
    bni -= cni;
    cni /= 2;
    Console.Write(cni);
}
}
Z2();
