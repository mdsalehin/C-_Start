//Operators
int x = 5;
int y = x + 10;

int a = x - 5;
int b = x / 5;
int c = x % 5;
int d = x * 5;

x++; // x = x + 1;
++x; // x = x + 1;
x--; // x = x - 1;
--x; // x = x - 1;

int m = 5;
int t = m++;
Console.WriteLine(t);

Console.WriteLine("Here is the difference");
int o = 12;
int q = ++o;
Console.WriteLine(q);

x += 5; // x = x + 5;
x *= 5; // x = x * 5;

bool v = x > 5;
v = x < 5; ;
v = x >= 5;
v = x <= 5;
v = x == 5;
v = x != 5;

Console.WriteLine("same calculation but big diffrence in data type issues");
Console.WriteLine(16.8f / 4.1f);   // output: 4.097561                      f = float
Console.WriteLine(16.8d / 4.1d);   // output: 4.09756097560976              d = double 
Console.WriteLine(16.8m / 4.1m);   // output: 4.09756097560975609756097560  m = decimel

