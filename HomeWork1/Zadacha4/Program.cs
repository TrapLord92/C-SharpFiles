
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Enter a number"); 
string? valueString = Console.ReadLine();
int x = Convert.ToInt32(valueString); 
string numBers = ""; 

int counter = 2;
string storm = "";

while(counter <= x){
    if (counter > 2){
   storm= ", ";
    }
   numBers = numBers + storm + counter;
    counter +=2;
}
System.Console.WriteLine($"The number {valueString} his 'Четные числа' are -: {numBers}"); 

