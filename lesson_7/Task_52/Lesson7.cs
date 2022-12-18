using static MyLibrary;
public class Lesson_7
{
    public static void Task_52()
    {
        int column = InformationFromUser("Введите количество столбцов");
        int lines = InformationFromUser("Введите количество строк");
        int[,] array = CreateArray(lines, column);
        FillArray(array);
        PrintArray(array);
        AverageNumber(array, lines);
    }
}