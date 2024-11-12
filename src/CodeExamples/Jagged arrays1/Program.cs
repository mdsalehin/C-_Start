// Directly initializing the jagged array with 3 sub-arrays
int[][] jugg1 = new int[][]
{
    new int[] { 1, 2, 3, 4 },   // First sub-array
    new int[] { 8, 12 },        // Second sub-array
    new int[] { 3, 7, 9 }       // Third sub-array
};

// Printing the jagged array
for (int i = 0; i < jugg1.Length; i++)
{
    for (int j = 0; j < jugg1[i].Length; j++)
    {
        Console.Write(jugg1[i][j] + " ");
    }
    Console.WriteLine(); // Move to the next line after printing each sub-array
}


Console.WriteLine();
Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");

//Using Loop Initialization
Console.WriteLine("Using Loop Initialization:\r\n");

int[][] jugg2 = new int[3][]; // Declare the jagged array with 3 sub-arrays

// Initialize each sub-array with different sizes
jugg2[0] = new int[4]; // Size 4
jugg2[1] = new int[2]; // Size 2
jugg2[2] = new int[3]; // Size 3

// Using a predefined set of values for initialization
int[,] values = new int[,]
{
    {1, 2, 3, 4}, // Values for the first sub-array
    {8, 11, 0, 0}, // Values for the second sub-array (extra 0s ignored)
    {3, 7, 9, 0}  // Values for the third sub-array (extra 0s ignored)
};


int totalItems = 0; // Initialize counter

for (int i = 0; i < jugg2.Length; i++)
{
    for (int j = 0; j < jugg2[i].Length; j++)
    {
        jugg2[i][j] = values[i, j];
        totalItems++;
    }
}
Console.WriteLine("Total number of items: " + totalItems);
// Print the array
for (int i = 0; i < jugg2.Length; i++)
{
    for (int j = 0; j < jugg2[i].Length; j++)
    {
        Console.Write(jugg2[i][j] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine();
Console.WriteLine("//////////////////////////////////////////////////////////////////////////////");
Console.WriteLine("Using Loops for User Input");


// Declare the jagged array with 3 sub-arrays
int[][] jugg3 = new int[3][];

// Initialize the jagged array sizes
jugg3[0] = new int[4]; // Size 4
jugg3[1] = new int[2]; // Size 2
jugg3[2] = new int[3]; // Size 3

// Taking user input for initialization
for (int i = 0; i < jugg3.Length; i++)
{
    Console.WriteLine($"Enter values for sub-array {i}:");
    for (int j = 0; j < jugg3[i].Length; j++)
    {
        Console.Write($"jugg3[{i}][{j}] = ");
        jugg3[i][j] = int.Parse(Console.ReadLine()); // Taking input from user
    }
}

Console.WriteLine();

// Printing the jagged array
for (int i = 0; i < jugg3.Length; i++)
{
    for (int j = 0; j < jugg3[i].Length; j++)
    {
        Console.Write(jugg3[i][j] + " ");
    }
    Console.WriteLine();
}
