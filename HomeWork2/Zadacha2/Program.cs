//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int InputInt(string message)
{
    System.Console.WriteLine(message + "  ");
    string? input_Value = Console.ReadLine();
    int result = Convert.ToInt32(input_Value);
    return result;
}
int numInT = InputInt("Введите число");

    if (numInT / 100 == 0)
{
    System.Console.WriteLine("Третьей цифры нет");
}
    else
{
    while (numInT > 1000)
    {
        numInT = numInT / 10;
    }
    System.Console.WriteLine($" третью цифру заданного числа -: {numInT % 10}");
}
