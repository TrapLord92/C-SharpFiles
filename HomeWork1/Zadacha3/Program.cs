
// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).


System.Console.WriteLine("Welcome!!"); 

System.Console.WriteLine(" "); 

System.Console.WriteLine("Enter a number"); 

string? valueString = Console.ReadLine();
int User_data = Convert.ToInt32(valueString); 
int deliver = User_data % 2; 

string answer = "Нечетное";

if (deliver == 0)


{ 
    answer = "Четное";
}
System.Console.WriteLine($"The number you enter is -:{answer}"); 
