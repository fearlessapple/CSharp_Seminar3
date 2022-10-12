Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "");

Console.Write($"{N} -> ");
PrintSquares(N);


static void PrintSquares(int N)
{
    for(int i = 1; i < N; i++)
    {
        Console.Write($"{i*i*i}, ");
    }
    Console.Write($"{N*N*N}");
}
