using static MyLibrary;
public class Lesson_9
{
    public static void Task_68()
    {
        int intM = InformationFromUser("Введите число M");
        int intN = InformationFromUser("Введите число N");
        int result = AkkermanFunction(intM, intN);
        Console.WriteLine();
        Console.Write($"A(m,n) =  {result}");

    }
}