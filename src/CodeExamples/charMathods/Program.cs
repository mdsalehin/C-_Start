
//Now char ar Mathod
Console.WriteLine("char r Mathod usign .char sign and used");
bool var = char.IsLetter('9');
Console.WriteLine(var);



/*Console.WriteLine("Enter a character input:");
char input = (char)Console.Read();
Console.WriteLine("Console print output only: " + char.IsLetterOrDigit(input));
*/
while (true)
{
 
    char input1 = (char)Console.Read();


    if (input1 == '\r' || input1 == '\n')
    {
        break;
    }
    Console.WriteLine(char.IsLetterOrDigit(input1));
}


