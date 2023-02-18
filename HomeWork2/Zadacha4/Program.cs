
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета.

System.Console.WriteLine($"Welcome");

int Randomnumber()
{    
    Random start = new Random();
    return start.Next(100, 1000);
}
int check_number = Randomnumber();
int rank1 = check_number % 10;
int rank2 = check_number / 100;
int final = rank2 * 10 + rank1;
System.Console.WriteLine($"Изначальное число {check_number}, результат {final} ");
