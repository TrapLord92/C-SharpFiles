//#Урок 1. Знакомство с языком программирования С#//

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число"); 
string? mainString1 = Console.ReadLine();
System.Console.WriteLine("Введите второе число"); 
string? mainString2 = Console.ReadLine();
int firstValue = Convert.ToInt32(mainString1);
int secondValue = Convert.ToInt32(mainString2);


if (value1 > value2){
    System.Console.WriteLine($"Max = {firstValue} Min = {secondValue}");
}
else {
    System.Console.WriteLine($"Max = {secondValue} Min = {firstValue}");
}


/*Z1.2
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
System.Console.WriteLine("Введите первое число"); //запрос у юзера первого числа, сохранение в пер.1
string? valueString1 = Console.ReadLine();
System.Console.WriteLine("Введите второе число"); //запрос у юзера второго числа, сохранение в пер.2
string? valueString2 = Console.ReadLine();
System.Console.WriteLine("Введите третье число"); //запрос у юзера третьего числа, сохранение в пер.3
string? valueString3 = Console.ReadLine();
int value1 = Convert.ToInt32(valueString1);//перевод трех чисел в int
int value2 = Convert.ToInt32(valueString2);
int value3 = Convert.ToInt32(valueString3);
int Max = value1; //создание пер. Max, присвоение ей значения пер. 1
if (value2 > Max){ //если значение пер. 2 >, чем Max, то запись в Max пер. 2
    Max = value2;
}
if (value3 > Max){ //если значение пер. 3 >, чем Max, то запись в Max пер. 3
    Max = value3;
}
System.Console.WriteLine($"Max = {Max}"); // вывод Max


Z1.3
// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число"); //запрос у юзера числа, сохранение в пер.
string? valueString = Console.ReadLine();
int number = Convert.ToInt32(valueString); //перевод числа в int
int remainder = number % 2; //получается ли остаток после деления на 2
string NumberType = "нечетное";
if (remainder == 0)
{ //если остаток = 0, то значение четное
    NumberType = "четное";
}
System.Console.WriteLine($"Число {NumberType}"); // вывод - четное или нет

Z1.4
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Введите последнее число"); //запрос у юзера конечного числа, сохранение в пер.
string? valueString = Console.ReadLine();
int N = Convert.ToInt32(valueString); //перевод числа в int
string Numbers = ""; //проверка чисел от 1 до N, если четное, то добавляем к строке 
int count = 2;
string separator = "";
while(count <= N){
    if (count > 2){
    separator = ", ";
    }
    Numbers = Numbers + separator + count;
    count +=2;
}
System.Console.WriteLine($"Четные числа: {Numbers}"); // вывод всех четных чисел в заданном числе









