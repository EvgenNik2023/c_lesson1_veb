Console.Write("Введите число: ");
string input1 = Console.ReadLine();
Console.Write("Введите число: ");
string input2 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);
int number2 = Convert.ToInt32(input2);
if (number2 * number2 == number1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
