public class Library
{
    // 1. Создать массив

    public static int[] CreateArray(int count)
    {
        return new int[count];
    }
    // 2. Заполнить массив положительными трехзначными числами
    public static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(100, 999);
        }
    }

    // 3. Показать массив
    public static string Print(int[] array)
    {
        return String.Join(' ', array);
    }

    // 4. Выборка четных чисел
    // 5. Подсчет количества четных чисел
    // 6. Вывод количества

    public static void FindNumber(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                result = result + 1;
            }
        }
        Console.WriteLine(result);
    }

}
