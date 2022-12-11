// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow

int numA = 2;
int numB = 4;

void countDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    Console.Write(result);
}
countDegree(numA, numB);