int ConvertToNumber(string textMessage)
{
    System.Console.Write(textMessage);
    string textNumber = Console.ReadLine();
    int convertNumber = int.Parse(textNumber);
    return convertNumber;
}

int GetSumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int inputNumber = ConvertToNumber("Введите число: ");
System.Console.WriteLine($"Сумма чисел в цифре {inputNumber} равна: {GetSumNumbers(inputNumber)}");
