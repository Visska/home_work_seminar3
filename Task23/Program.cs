/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

int PowNumber(int number, int grade)
{
    int result = 1;
    for (int i = 0; i < grade; i++)
    {
        result *= number;
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел от 1 до N: ");
for (int i = 1; i <= numberN; i++ )
{
    int cubeNumber = PowNumber(i, 3);
    Console.Write($"{cubeNumber} ");
}

