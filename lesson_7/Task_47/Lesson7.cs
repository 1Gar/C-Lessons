using static MyLibrary;
public class Lesson_7
{
    public static void Task_47()
    {
        int column = InformationFromUser("Введите количество столбцов");
        int lines = InformationFromUser("Введите количество строк");
        double[,] array = CreateArray(lines, column);
        FillArray(array);
        PrintArray(array);
    }
}