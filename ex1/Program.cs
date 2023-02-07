// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int PutNumber(string text) 
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetStepen(int a, int b)
{
    int result = 1;
    
    for (int i = 1; i<=b; i++)
    {
        result = result * a;
    }
    return result;
}
int num = PutNumber("Введите число A ");
int num2 = PutNumber("Введите число B ");
int Stepen = GetStepen(num, num2);


System.Console.WriteLine($"{num} в степени {num2} = {Stepen}");