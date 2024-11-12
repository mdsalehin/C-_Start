/*s = s << 1;
s = s <<= 2;
s >>= 3;*/

using System.Diagnostics.Metrics;

int s = 5;            // 0101
int s2 = 9;           // 1001

int s3 = s2 & s;      // 0001 compare s and s2 with bit and operations.
Console.WriteLine(s3);

int s4 = s2 | s;
Console.WriteLine(s4); //1101 = 13

int s5 = 0b_0110_1100_0010; //1730 decimale values
Console.WriteLine(s5);

int s6 =  0x_19AF_20FB; //HexaDecimale
Console.WriteLine(s6);

//shift operation
int s7 = 0b_0110_1100_0010; //1730 decimale values
Console.WriteLine($"s7 before the shift operation: {Convert.ToString(s7, toBase: 2)}");
//Console.WriteLine(Convert.ToString(s7, toBase: 2));

s7 = s7 << 1;
Console.WriteLine($"s7 after the shift operation:  {Convert.ToString(s7, toBase: 2)}");
Console.WriteLine(s7);

s7 = s7 >> 2;
Console.WriteLine(Convert.ToString(s7, toBase: 2)); //001101100001
