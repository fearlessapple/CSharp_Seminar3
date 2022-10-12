Console.Clear();

Console.Write("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine() ?? "");

int LastNumber = N % 10;
int PreLastNumber = (N / 10) % 10;
int SecondNumber = (N / 1000) % 10;
int FirstNumber = N / 10000;

if(FirstNumber == LastNumber && SecondNumber == PreLastNumber)
{
    Console.WriteLine($"{N} -> да");
}
else
{
    Console.WriteLine($"{N} -> нет");
}