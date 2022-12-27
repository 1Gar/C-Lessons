using static MyLibrary;
public class Lesson_8
{
    public static void Task_60()
    {
        int x = InformationFromUser("Введите X");
        int y = InformationFromUser("Введите Y");
        int z = InformationFromUser("Введите Z");
        int[,,] array = CreateArray(x, y, z);
        FillArray(array);
        Console.WriteLine();
        PrintArray(array);
    }
}