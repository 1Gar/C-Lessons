public class MyLibrary
{
    //1. Функция вывода текста и получения данных от пользователя

    public static int InformationFromUser(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;

    }
    //2. Функция создания двухмерного массива

    public static int[,] CreateArray(int lines, int column)
    {
        return new int[lines, column];
    }
    //3. Функция заполнения массива числами

    public static void FillArray(int[,] numbers)
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[i, j] = Convert.ToInt32(new Random().Next(0, 10));
            }
        }
    }
    //4. Функция вывода массива
    public static void PrintArray(int[,] numbers)
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            Console.Write("");
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write(numbers[i, j] + " ");
            }
            Console.Write("");
            Console.WriteLine("");
        }
    }
    //5. Нахождение элемента в массиве
    public static void FindNumber(int[,] numbers, int lines, int column)
    {
        if (lines > numbers.GetLength(0) || column > numbers.GetLength(1))
        {
            Console.WriteLine("Такого элемента нет");
        }
        else
        {
            Console.WriteLine($"Значение элемента {lines} строки и {column} столбца равно {numbers[lines - 1, column - 1]}");
        }
    }

}