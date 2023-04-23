System.Console.WriteLine("Ваш массив:");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] randomArray = new int[8];

FillArray(randomArray);
PrintArray(randomArray);
