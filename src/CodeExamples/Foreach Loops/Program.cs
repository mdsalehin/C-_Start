
/*
    foreach loops ta use ta use korte hoi collection data type ar upore.
    so array one kinds of collection of  datatypes so we can use it.
 */

//single dimention array declear .short cut syntext only work for single dimention array to be work.
int[] ages = [30, 31, 18, 24, 25, 26];

double sum = 0;
foreach(int variablesStoreFromAges in ages)
{
    sum  = sum + variablesStoreFromAges;
}
Console.WriteLine(sum/ages.Length);
