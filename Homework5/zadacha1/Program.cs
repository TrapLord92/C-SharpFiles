
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2*/


Console.WriteLine("Введите длину массива");

int size = Convert.ToInt32(Console.ReadLine());
int[] user_numbers = new int[size];

FillArrayRandomNumbers(user_numbers);
Console.WriteLine("Прелагаем массив: ");
PrintArray(user_numbers);

int count = 0;

for (int a = 0; a < user_numbers.Length; a++)
if (user_numbers[a] % 2 == 0)
count++;

Console.WriteLine($"всего {user_numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < user_numbers.Length; i++)
    {
        user_numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ]");
    for(int i = 0; i < user_numbers.Length; i++)
    {
        Console.Write(user_numbers[i] + " ");
    }
    Console.Write("[]");
    Console.WriteLine();
}