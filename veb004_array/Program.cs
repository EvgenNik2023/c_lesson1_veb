Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
int number1 = 0 - number;
Console.Write("\"");
while (number1 < number)
{
    Console.Write(number1 + ", ");
    number1++;
}
Console.WriteLine(number + "\"");
