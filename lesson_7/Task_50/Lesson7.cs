using static MyLibrary;
public class Lesson_7
{
    public static void Task_50()
    {
        int lines = InformationFromUser("Введите номер строки");
        int column = InformationFromUser("Введите номер столбца");
        int[,] array = CreateArray(10, 10);
        FillArray(array);
        PrintArray(array);
        FindNumber(array, lines, column);

    }
}