Console.Write("Введите число: ");
string textN = Console.ReadLine();
int number = int.Parse(textN);
Console.Write("Введите степень, в которую необходимо возвести число: ");
string textD = Console.ReadLine();
int degree = int.Parse(textD);

double result = Math.Pow(number, degree);
Console.Write($"Результат возведения в степень: {result}");
