//#Урок 1. Знакомство с языком программирования С#//

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


System.Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, a какое меньшее .");

System.Console.WriteLine("Enter your luck number"); 
string? mainString1 = Console.ReadLine();
System.Console.WriteLine("Great!!, Now Enter any number to check your luck"); 
string? mainString2 = Console.ReadLine();
int firstValue = Convert.ToInt32(mainString1);
int secondValue = Convert.ToInt32(mainString2);


if (firstValue > secondValue){
    System.Console.WriteLine($"Congratulations!! your max Value is : = '{firstValue}' ");
}
else {
    System.Console.WriteLine($"Congratulations!! your max Value is : = '{secondValue}' ");
}
