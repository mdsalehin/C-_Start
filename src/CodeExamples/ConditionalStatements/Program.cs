using System.Globalization;

int x = 5;

if(x > 5)
{
    Console.WriteLine("X is big");
}

else if( x == 5)
{
    Console.WriteLine("x is equal");
}
else if( x > 10)
{
    Console.WriteLine("x is very big");
}
else
{
    Console.WriteLine("X is small");
}

switch (x)
{

    case 1:
        Console.WriteLine("Case 1: x is 1");
        break;

    case 2:
        Console.WriteLine("Case 2: x is 2");
        break;

    case 3:
        Console.WriteLine("Case 3: x is 3");
        break;

    default:
        Console.WriteLine("Default case: x does not match any case");
        break;

}

Console.WriteLine("Tarnari Operator");

string name = " md salahin";

string uppercaseName = name != null ? name.ToUpper() : null;

/*name != null ?  if ar mto this is like condition
name.ToUpper() if jdi true hoi tahole execute hobe this is statement indicate the values
null; if jdi flase hoi tahole execute hobe.another values */

Console.WriteLine(uppercaseName);

/* 
   Explanation:
   - `name != null ?` → This checks if the `name` is not null (similar to an `if` condition).
   - `name.ToUpper()` → If the condition is true (`name` is not null), it converts the `name` to uppercase.
   - `null` → If the condition is false (`name` is null), it assigns `null` to `uppercaseName`.
*/
