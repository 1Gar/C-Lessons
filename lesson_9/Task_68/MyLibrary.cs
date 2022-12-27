public class MyLibrary
{
    //1. Функция вывода текста и получения данных от пользователя

    public static int InformationFromUser(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
    //2. Функция Аккермана
    public static int AkkermanFunction(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return AkkermanFunction(m - 1, 1);
        else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
}