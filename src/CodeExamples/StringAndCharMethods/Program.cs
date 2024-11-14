//string mathod list node in google classroom
string name = "my name is salahin";
Console.WriteLine(name);

bool cheakingPresentOrNot = name.Contains("is");
Console.WriteLine(cheakingPresentOrNot);

int temp = name.IndexOf('i');
Console.WriteLine("index position of = " + temp);

int temp1 = name.LastIndexOf('i');
Console.WriteLine("index position of = " + temp1);

name  =  name.ToUpper();
Console.WriteLine(name);

string name1 = "salahin";
name1 = name1.PadLeft(name1.Length + 5, '*');
Console.WriteLine(name1);

string name2 = "salahin";
Console.WriteLine(name2.PadRight(name2.Length + 5, '#'));

//substring
string store = name2.Substring(2, 3);
Console.WriteLine(store);

string searchString = "al";
string s1 = "salahin";
string s2 = "animal";

Console.WriteLine(s1.IndexOf(searchString, 1));
Console.WriteLine(s2.IndexOf(searchString, 2));

// The example displays the following output: 1 && 4

/*
    The IndexOf method searches for the exact substring starting from a specified index.
    "al" is found at index 1 in "salahin" when starting the search from index 1.
    "al" is found at index 4 in "animal" when starting the search from index 2.
*/

