// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Строки использовать нельзя

int num = 9012;
int i = 0;
int countIndex(int a)
{
    while (a > 0)
    {
        a /= 10;
        i++;
    }
    return i;
};
countIndex(num);

void countSumNumber(int i, int b)
{
    int result = 0;
    for (int j = 0; j <= i; j++)
    {
        result += b % 10;
        b /= 10;
    }
    Console.WriteLine(result);

};
countSumNumber(i, num);



