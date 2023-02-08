// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
string? PutNumber(string text)
{
    System.Console.Write(text);
    return Console.ReadLine();
}

int GetSum(string sum)
{
    int lenght = sum.Length;
    int result = Convert.ToInt32(Convert.ToString((sum[0])));
    for (int i = 1; i < lenght; i++)
    {
        result = Convert.ToInt32(Convert.ToString(sum[i])) + result;
    }
    return result;
}
string? a = PutNumber("Введите число: ");
System.Console.WriteLine($"Сумма цифр в числе {a} = {GetSum(a)}");


