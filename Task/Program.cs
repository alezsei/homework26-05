int InText(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task19()
{
    int num1 = InText("Введите пятизначное число");
    if (num1 > 9999 && num1 < 100000)
    {
        if ((num1 / 10000 == num1 % 10) && ((num1 % 100 ) / 10 == num1 / 1000 % 10))
        {
            Console.WriteLine("Палиндром");
        }
        else Console.WriteLine("Не палиндром");
    }
    else Console.WriteLine("Число не пятизначное");
}
Task19();



