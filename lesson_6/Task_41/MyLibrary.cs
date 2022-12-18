public class MyLibrary
{
    //1. Создание массива
    // public static int[] CreateArray(int value)
    // {
    //     return new int[value];
    // }

    //2. Заполнение массива

    // public static void FillArray(int[] array)
    // {
    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         array[i] = Random.Shared.Next(-10, 20);
    //     }
    // }

    //---------------------------------------------

    //1. Ввод чисел пользователем через запятую

    public static string WriteLine(string text)
    {
        Console.WriteLine(text);
        string texts = Console.ReadLine();
        return texts;
    }

    //2. Перевод строки в массив

    //2.1 Подсчет количества элементов массива, ориентируясь на запятые 
    public static int[] StringToArray(string texts)
    {
        int count = 1;
        for (int i = 0; i < texts.Length; i++)
        {
            if (texts[i] == ',')
            {
                count++;
            }
        }
        //2.2 Создание массива с определенным ранее количеством элементов
        int[] numbers = new int[count];
        int index = 0;

        for (int i = 0; i < texts.Length; i++)
        {
            string temp = "";

            while (texts[i] != ',')
            {
                if (i != texts.Length - 1)
                {
                    temp += texts[i].ToString();
                    i++;
                }
                else
                {
                    temp += texts[i].ToString();
                    break;
                }
            }
            numbers[index] = Convert.ToInt32(temp);
            index++;
        }
        return numbers;
    }


    //3. Вывод массива

    public static string PrintArray(int[] array)
    {
        return String.Join(' ', array);
    }
    //4. Посчитать, сколько чисел больше 0 ввёл пользователь.

    public static void CountNumber(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                result = result + 1;
            }
        }
        Console.WriteLine(result);
    }
}