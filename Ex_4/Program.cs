Console.Clear();
Console.Write ("Ввведите число N: ");
int N=int.Parse(Console.ReadLine());
int number=1;

while(number<N)
{
    if(number%2==0)
    {
        Console.Write($"{number}");
    }
    number = number + 1;
}