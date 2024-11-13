//Mathod Benifite aki jnish akabr laklai chole.
void PrintMax(int a, int b)
{
    int c = a;

    if( b > a)
    {
        c = b;
    }
    Console.WriteLine(c);
}
PrintMax(5, 9);
PrintMax(30, 12);
PrintMax(2, 2);

Console.WriteLine("return mathods");
int GetReturn(int c, int d)
{
    int result = c;

    if(d > c)
    {
        result = d;
    }
    return result;
}

Console.WriteLine(GetReturn(5, 19));  // Output: 9
Console.WriteLine(GetReturn(30, 45)); // Output: 30
Console.WriteLine(GetReturn(15, 2));   // Output: 2


int rr = GetReturn(5, 1); // Output: 1
Console.WriteLine(rr);



