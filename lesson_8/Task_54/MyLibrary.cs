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

    //5. Функция упорядочения элементов двуxмерного массива
    public static void OrderArrayLines(int[,] numbers)
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                for (int k = 0; k < numbers.GetLength(1) - 1; k++)
                {
                    if (numbers[i, k] < numbers[i, k + 1])
                    {
                        int temp = numbers[i, k + 1];
                        numbers[i, k + 1] = numbers[i, k];
                        numbers[i, k] = temp;
                    }
                }
            }
        }
    }

}