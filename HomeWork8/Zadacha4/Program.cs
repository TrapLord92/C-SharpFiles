//Напишите программу, которая заполнит спирально квадратный массив.



int len = 5;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);

void FillArraySpiral(int[,] arr, int b) 
{
    int i = 0, j = 0;
    int val = 1;
    for (int a = 0; a < b * b; a++)
    {
        int c = 0;
        do { arr[i, j++] = val++; } while (++c < b - 1);
        for (c = 0; c < b - 1; c++) arr[i++, j] = val++;
        for (c = 0; c < b - 1; c++) arr[i, j--] = val++;
        for (c = 0; c < b - 1; c++) arr[i--, j] = val++;
        ++i; ++j;
        b = b < 2 ? 0 : b - 2; 
    }
}

void PrintArray(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
            {
                Console.Write("0" + arr[i, j]);
                Console.Write(" ");
            }
            else Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
    
