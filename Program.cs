﻿void Z1 () 
{
string [,] table = new string[2, 5];
table[1, 2] = "cсло";
for (int rows = 0; rows>2; rows++) 
{
    for (int col = 0; col < 5; col++) 
    {
        Console.Write($"{table[rows, col]}-");
    }
    Console.WriteLine("");
}

}
// table[2, 3] = "воо";

// }

Z1();