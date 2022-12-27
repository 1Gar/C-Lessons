using static MyLibrary;
public class Lesson_8
{
    public static void Task_56()
    {
        int column = InformationFromUser("Введите количество столбцов");
        int lines = InformationFromUser("Введите количество строк");
        int[,] array = CreateArray(lines, column);
        FillArray(array);
        PrintArray(array);
        Console.WriteLine();
        int sumLine = SumLine(array, 0);
        MinSum(array);
    }
}