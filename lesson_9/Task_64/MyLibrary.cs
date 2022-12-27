public class MyLibrary
{
    //1. Функция вывода текста и получения данных от пользователя

    public static int InformationFromUser(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
    //2. Функция вывода натуральных чисел
    public static void FindNaturalInt(int number)
    {
        int n = number;
        if (number == 0) return;
        {
            Console.Write(number + " ");
            FindNaturalInt(number - 1);
        }
    }


}