int countA, countB, result;
Console.Write("Введите число A: ");
countA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
countB = Convert.ToInt32(Console.ReadLine());
result = countA;
for (int i = 2; i <= countB; i++)
{
    result *= countA;
}
Console.WriteLine($"{countA}^{countB} = {result}");