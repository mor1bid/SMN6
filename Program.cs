void Z1 () 
{
Console.Write("1. ");
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
Z1();
}

void Z2 () 
{
Console.Write("2. ");
int [,] table = new int[2, 5];
for (int bar = 0; bar < 2; bar++)
{
    for (int col = 0; col < 5; col++) 
    {
        Console.Write($"{table[bar, col]} ");
    }
    Console.WriteLine("");
}
Z2();
}

void Z3() 
{
Console.Write("3. ");
int [,] table = new int[25, 22];
for (int bar = 0; bar < 25; bar++) 
{
    for (int col = 0; col < 22; col++) 
    {
        Console.Write($"{table[bar, col]} ");
        if(table[bar, col] == 0) Console.Write($" ");
        else Console.Write($"+");
    }
    Console.WriteLine("");
}
}
Z3();

Console.Write("4. ");
double Z4(int n)
{
    if(n == 1) return 1;
    else return n + Z4(n-1);
}
//Console.WriteLine("Введите число: ");
for (int i = 1; i < 40; i++) 
{
    Console.WriteLine(Z4(i));
}

Console.Write("5. ");
int Z5(int n) // числа Фибоначчи
{
    if(n == 1 || n == 2) return 1;
    else return Z5(n-1) + Z5(n-2);
}
for (int i = 1; i< 10; i++) 
{
    Console.WriteLine(Z5(i));
}
