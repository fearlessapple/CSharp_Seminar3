int A1, A2, B1, B2, C1, C2;

A1 = UserInputCoordinate("Введите координату Х первого числа: ");
Console.WriteLine(A1);
A2 = UserInputCoordinate("Введите координату Y первого числа: ");
Console.WriteLine(A2);
C1 = UserInputCoordinate("Введите координату Z первого числа: ");
Console.WriteLine(C1);
B1 = UserInputCoordinate("Введите координату Х второго числа: ");
Console.WriteLine(B1);
B2 = UserInputCoordinate("Введите координату Y второго числа: ");
Console.WriteLine(B2);
C2 = UserInputCoordinate("Введите координату Z второго числа: ");
Console.WriteLine(C2);

double distance = Distance(A1, A2, B1, B2, C1, C2);
Console.WriteLine(distance);

static int UserInputCoordinate(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double Distance(int A1, int A2, int B1, int B2, int C1, int C2)
{
    double result = Math.Sqrt(Math.Pow(B1 - A1, 2) + Math.Pow(B2 - A2, 2) + Math.Pow(C2 - C1, 2));
    return result;
}
