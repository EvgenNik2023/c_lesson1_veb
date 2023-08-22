Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
int digit = number % 10;
Console.WriteLine(digit);