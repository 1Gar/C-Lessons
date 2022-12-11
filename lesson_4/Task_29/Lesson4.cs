// Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15
// N: 3 [9, 4, 12] => 2097
// Для проверки можно использовать https://numsys.ru/convert/2097/10/15


using static MyLibrary;
public class Lesson4
{
    public static void Task29()
    {
        int[] ar = CreateArray(5);
        Fill(ar);
        // Console.WriteLine(Print(ar));
        int dec = ToDec(ar);
        Console.WriteLine($"{Print(ar)} => {dec}");
    }
}
