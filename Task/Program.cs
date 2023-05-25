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
//Task19();

void Task21()
{
    int x1 = InText("Введите координату Х первой точки");
    int y1 = InText("Введите координату Y первой точки");
    int z1 = InText("Введите координату Z первой точки");
    int x2 = InText("Введите координату Х второй точки");
    int y2 = InText("Введите координату Y второй точки");
    int z2 = InText("Введите координату Z второй точки");
    Console.WriteLine (Math.Round((Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2-z1,2))),2));

}

//Task21();

void Task23()
{
    int n = InText("Введите N");
    if (n > 0)
    {
        for(int count = 1; n >= count; count++)
        {
            Console.Write( Math.Pow(count,3));
            Console.Write(" ");
        }
    }
    else Console.WriteLine("Введено отрицательное число, попробуйте снова");

}
Console.Clear();
Task23();
