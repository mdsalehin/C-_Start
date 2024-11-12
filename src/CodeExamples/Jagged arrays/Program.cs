//Jugged Array

/*A jagged array is an array whose elements are arrays, possibly of different sizes.
A jagged array is sometimes called an "array of arrays." 
Its elements are reference types and are initialized to null.*/

/*
[1,2,3,4] 
[8,12]
[3,7,9]
*/
//Protita 1D array size different 


using System.Net.NetworkInformation;

int[][] jugg = new int[3][];

//Jugged Array size declearation
jugg[0] = new int[4];
jugg[1] = new int[2];
jugg[2] = new int[3];

// Initialize with specific values

jugg[0][0] = 1;
jugg[0][1] = 2;
jugg[0][2] = 3;
jugg[0][3] = 4;

jugg[1][0] = 8;
jugg[1][1] = 12;

jugg[2][0] = 3;
jugg[2][1] = 7;
jugg[2][2] = 9;

// Print the jagged array
for (int i = 0; i<jugg.Length; i++)
{
    for(int j = 0; j < jugg[i].Length; j++)
    {
        Console.Write($"jugg[{i}, {j}] = {jugg[i][j]}\t");
       // Console.Write(jugg[i][j] + " " );
    }
    Console.WriteLine();
}

