
//Another Input Process 
void InputProcees2()
{
    //int count  = int.Parse(Console.ReadLine());

    string varibale = Console.ReadLine();
    int count = int.Parse(varibale);


    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        string numline = Console.ReadLine();
        array[i] = int.Parse(numline);

    }
    int sum = 0;
    /* for (int i = 0;i < count; i++)
     {
         sum = sum + array[i];
     }*/

    foreach (int variabless in array)
    {
        sum = sum + variabless;

    }
    Console.WriteLine(sum);
}
InputProcees2();
//InputProcees2();



/* sample input and output
   5 
  5 5 5 5 5 = 20 */

/*
 Why Parse Is Necessary:
  The   Console.ReadLine()      method always returns a string regardless of what the user types, 
  so to store the value as an int, you need to convert it using int.Parse().
 */