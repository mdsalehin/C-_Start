
string line  = Console.ReadLine();

string[] lineParts   = line.Split(',', ' ');

for (int i = 0; i < lineParts.Length; i++)
{
    lineParts[i] = lineParts[i].Trim();
}

int[] numbers = new int[lineParts.Length];
int count = 0;

foreach(string varibale in lineParts)
{
    if(!string.IsNullOrWhiteSpace(varibale))
    {
        //string to int convert using parse mathodes
        numbers[count++] = int.Parse(varibale);
    }

}
/*for(int i = 0; i<lineParts.Length; i++)
{
    if (!string.IsNullOrWhiteSpace(lineParts[i]))
    {
        //string to int convert using parse mathodes
        numbers[count++] = int.Parse(lineParts[i]);
    }
}*/

for (int i = 0;i < count; i++)
{
    Console.WriteLine(numbers[i]);
}
//Alternative of for loops this will also work

/*foreach(int var  in numbers.Take(count))
{
    Console.WriteLine(var);
}*/

int sum = 0;
for (int i = 0; i<count; i++)
{
    sum = sum + numbers[i];
}
Console.Write("Sumation of the result = " +  sum);

/*
 output is like  = 1,,,,,,,, 5 ,,,,4 = 10
 */

// this is the formate where i do not need to menation how many number to be taken. 
