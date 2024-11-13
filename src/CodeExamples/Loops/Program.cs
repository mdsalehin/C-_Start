//For loops
for(int i = 0 ; i < 10; i++)
{
   
    if(i == 5)
    {
        continue;
    }
   
    if(i == 7)
    {
        break;      
    }
    
    Console.WriteLine(i); 

}

Console.WriteLine("Stop the code you have to peress enter");
Console.WriteLine("Enter an input of stirng name or somethign else");

while(true)
{
   string line  =  Console.ReadLine();

    if(line == String.Empty)
    {
        break ;
    }
    else
    {
        Console.WriteLine(" My line is: " + line);
    }

}

//DO WHILE LOOP
Console.WriteLine("DO WHILE LOOP ");
int x = 5;
do
{
    Console.WriteLine(x);
    x--;
}
while (x > 0);

//while loop 
int y = 0;
while (y > 0)
{
    Console.WriteLine(y);
    y--;
}

Console.WriteLine("Here is the differnec between while and do while loop");
int z = 0;
do
{
    Console.WriteLine(z);
    z--;
}
while (z > 0);