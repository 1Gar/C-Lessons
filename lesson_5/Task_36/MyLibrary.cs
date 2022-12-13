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
            array[i] = Random.Shared.Next(10, 50);
        }
    }
    // 3. Вывести массив
    public static string PrintArray(int[] array)
    {
        return String.Join(' ', array);
    }
    // 4. Найти нечетные индексы
    // 5. Выбрать числа на этих индексах
    // 5. Сумма чисел
    // 6. Вывод суммы чисел
    public static void FindNum(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 1)
            {
                result = result + array[i];
            }
        }
        Console.WriteLine(result);
    }
}