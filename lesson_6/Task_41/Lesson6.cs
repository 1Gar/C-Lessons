using static MyLibrary;
public class Lesson_6
{
    public static void Task_41()
    {
        // int[] numbers = CreateArray(10);
        // FillArray(numbers);
        string readText = WriteLine("Введите числа через запятую");
        int[] numbers = StringToArray(readText);
        Console.WriteLine(PrintArray(numbers));
        CountNumber(numbers);
    }
}