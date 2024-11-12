//Array

//datatypes ar por [] declearing an array = new again datatypes [size]

int[] x = new int[20];
bool[] y = new bool[10];
string[] s = new string[25];
DateTime[] d = new DateTime[12];


//Value assign in array
x[0] = 1;
x[1] = 2;
x[2] = 3;

//Another process Value assign in array
char[] c = new char[] {'a','b','#'};
char[] l = new char[3] { 'a', 'b', '#' };
int[] z = new int[7] {1,2,3,4,5,9,10};
int[] u = new int[] { 1, 2, 3, 4, 5, 9, 10 };

//Print array
Console.WriteLine("Print array");
for (int i = 0; i < x.Length; i++)
{
    Console.Write(x[i] + " ");
}
Console.WriteLine();

Console.WriteLine("one loop all the inter single array called Print array");
//one loop all the inter single array called Print array
void PrintIntArray(int[] array, string name)
{
    Console.Write($"{name}: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
PrintIntArray(x, "x");
PrintIntArray(z, "z");
PrintIntArray(u, "u");


Console.WriteLine("Printing the 2D Array");
//Working With 2d array 
int[,] grid = new int[3, 4];

grid[0, 0] = 2;
grid[1, 0] = 3;
grid[2, 0] = 4;

grid[0, 1] = 5;
grid[1, 1] = 6;
grid[2, 1] = 7;

grid[0, 2] = 8;
grid[1, 2] = 9;
grid[2, 2] = 10;

grid[0, 3] = 11;
grid[1, 3] = 12;
grid[2, 3] = 13;


//Printing the 2D Array
for(int i = 0; i<3; i++)
{
    for(int j = 0; j<4; j++)
    {
        Console.Write($"grid[{i}, {j}] = {grid[i, j]}\t");
       // Console.Write(grid[i, j] + "\t");
    }
    Console.WriteLine();
}