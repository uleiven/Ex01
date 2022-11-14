Console.Clear();
Console.Write ("Ввведите первое число: ");
int A=int.Parse(Console.ReadLine());

Console.Write ("Ввведите второе число: ");
int B=int.Parse(Console.ReadLine());

int max = A;

if (B > max) max = B;
if (A > max) max = A;

Console.Write("max = ");
Console.WriteLine(max);