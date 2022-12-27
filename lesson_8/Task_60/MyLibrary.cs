public class MyLibrary
{
    //1. Функция вывода текста и получения данных от пользователя

    public static int InformationFromUser(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    //2. Функция создания трехмерного массива исходя их данных пользователя

    public static int[,,] CreateArray(int x, int y, int z)
    {
        return new int[x, y, z];
    }

    //3. Функция заполнения массива числами

    // public static void FillArray(int[,,] numbers)
    // {
    //     for (int i = 0; i < numbers.GetLength(0); i++)
    //     {
    //         for (int j = 0; j < numbers.GetLength(1); j++)
    //         {
    //             for (int d = 0; d < numbers.GetLength(2); d++)
    //             {
    //                 numbers[i, j, d] = Convert.ToInt32(new Random().Next(10, 99));
    //             }
    //         }
    //     }
    // }

    //4. Функция заполнения массива числами и проверки на дубли
    public static void FillArray(int[,,] numbers)
    {
        int[] temp = new int[numbers.GetLength(0) * numbers.GetLength(1) * numbers.GetLength(2)];
        int number;
        for (int i = 0; i < temp.GetLength(0); i++)
        {
            temp[i] = new Random().Next(10, 99);
            number = temp[i];
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (temp[i] == temp[j])
                    {
                        temp[i] = new Random().Next(10, 99);
                        j = 0;
                        number = temp[i];
                    }
                    number = temp[i];
                }
            }
        }
        int count = 0;
        for (int x = 0; x < numbers.GetLength(0); x++)
        {
            for (int y = 0; y < numbers.GetLength(1); y++)
            {
                for (int z = 0; z < numbers.GetLength(2); z++)
                {
                    numbers[x, y, z] = temp[count];
                    count++;
                }
            }
        }
    }

    //5. Функция вывода трехмерного массива с индексами

    public static void PrintArray(int[,,] numbers)
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            Console.Write("");
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                for (int d = 0; d < numbers.GetLength(2); d++)
                {
                    Console.Write(numbers[i, j, d] + "" + (i, j, d) + "  ");
                }
                Console.Write("");
                Console.WriteLine("");
            }

        }
    }


}