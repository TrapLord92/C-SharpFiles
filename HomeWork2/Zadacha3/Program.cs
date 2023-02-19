
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int InputInt(string message)
{
    System.Console.WriteLine(message + "  ");
    string inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int WeekDay = InputInt("Введите день недели");
     if (WeekDay == 7 || WeekDay== 6)
{
    System.Console.WriteLine("Да");
}
    else
{
    System.Console.WriteLine("Нет");
}
