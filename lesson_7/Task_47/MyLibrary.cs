public class MyLibrary
{
    //1. Функция вывода текста и получения данных от пользователя

    public static int InformationFromUser(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    //2. Функция создания двухмерного массива исходя их данных пользователя

    public static double[,] CreateArray(int lines, int column)
    {
        return new double[lines, column];
    }

    //3. Функция заполнения массива вещественными числами

    public static void FillArray(double[,] numbers)
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            }
        }
    }
    //4. Функция вывода массива

    public static void PrintArray(double[,] numbers)
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

}