Console.Clear();
Console.Write ("Ввведите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
Console.WriteLine("Число является чётным");
}
else
{
   Console.WriteLine("Введите другое число"); 
}