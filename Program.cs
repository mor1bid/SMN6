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

Z2();

Z1();

