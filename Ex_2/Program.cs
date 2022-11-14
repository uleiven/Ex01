Console.Clear();
Console.Write ("Ввведите первое число: ");
int A=int.Parse(Console.ReadLine());

Console.Write ("Ввведите второе число: ");
int B=int.Parse(Console.ReadLine());

Console.Write ("Ввведите третье число: ");
int C=int.Parse(Console.ReadLine());

int max = A;

if (C > max) max = C;
if (A > max) max = A;
if (B > max) max = B;

Console.Write("max = ");
Console.WriteLine(max);