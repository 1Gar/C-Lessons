using static MyLibrary;
public class Lesson_9
{
    public static void Task_66()
    {
        int numberMin = InformationFromUser("Введите минимальное натуральное число");
        int numberMax = InformationFromUser("Введите максимальное натуральное число");
        FindNaturalInt(numberMax, numberMin, 0);
    }
}