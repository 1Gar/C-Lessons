// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212->нет
// 12821->да
// 23432->да
// СТРОКИ ИСПОЛЬЗОВАТЬ НЕЛЬЗЯ

int num = 23432;

int check1 = num % 10;
int check11 = num / 10000;
int check2 = (num / 10) % 10;
int check22 = (num / 1000) % 10;

if (check1 == check11 || check2 == check22)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
