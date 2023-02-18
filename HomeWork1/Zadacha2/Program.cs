
 //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

System.Console.WriteLine("Enter 3 numbers"); 

System.Console.WriteLine("Введите первое число"); 
string? valueString1 = Console.ReadLine();
System.Console.WriteLine("Введите второе число"); 
string? valueString2 = Console.ReadLine();
System.Console.WriteLine("Введите третье число"); 


string? valueString3 = Console.ReadLine();
int value1 = Convert.ToInt32(valueString1);
int value2 = Convert.ToInt32(valueString2);
int value3 = Convert.ToInt32(valueString3);

int start = value1;


if (value2 >start){ 
    start = value2;
}
if (value3 > start){ 
    start = value3;
}
System.Console.WriteLine($"Your max number is -: = '{start}'");