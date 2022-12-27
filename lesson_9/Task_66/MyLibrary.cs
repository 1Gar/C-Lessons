public class MyLibrary
{
    //1. Функция вывода текста и получения данных от пользователя

    public static int InformationFromUser(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
    //2. Функция суммы натуральных чисел в промежутке
    public static void FindNaturalInt(int numberMax, int numberMin, int result)
    {

        if (numberMin > numberMax)
        {
            Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {result}");
            return;
        }
        result = result + (numberMin++);
        FindNaturalInt(numberMax, numberMin, result);




    }

}