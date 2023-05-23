int digit, result;
Console.Write("Введите любое число: ");
digit = Convert.ToInt32(Console.ReadLine());
result = 0;
while (digit != 0)
{
    result += digit % 10;
    digit /= 10;
}
Console.WriteLine($"Сумма цифр в числе = {result}");