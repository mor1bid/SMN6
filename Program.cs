void Z1 () 
{
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
// table[2, 3] = "воо";

// }

void Z2 () 
{
int [,] table = new int[2, 5];
for (int bar = 0; bar < 2; bar++) 
{
    for (int col = 0; col < 5; col++) 
    {
        Console.Write($"{table[bar, col]} ");
    }
    Console.WriteLine("");
}

}
// table[2, 3] = "воо";

// }
void Z3() 
{
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

double Z4(int n) 
//Console.WriteLine("Введите число: ");
{
    if(n == 1) return 1;
    else return n + Z4(n-1);
}
for (int i = 1; i < 40; i++) 
{
    Console.WriteLine(Z4(i));
}
//Z4(n);
Z3();
Z2();
Z1();

