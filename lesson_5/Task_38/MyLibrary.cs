public class MyLibrary
{
    // 1. Создать массива
    public static int[] CreateArray(int count)
    {
        return new int[count];
    }
    // 2. Заполнить массив
    public static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(5, 50);
        }
    }
    // 3. Вывести массив
    public static string PrintArray(int[] array)
    {
        return String.Join(' ', array);
    }
    // 4. Найти максимальное значение массива
    // 5. Найти минимальное значение массива
    // 6. Найти разницу между максимальным и минимальным элементом массива
    // 7. Вывести разницу между максимальным и минимальным элементом массива

    public static void FindResult(int[] array)
    {
        int max = array[0];
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        Console.WriteLine(max - min);
    }
}
