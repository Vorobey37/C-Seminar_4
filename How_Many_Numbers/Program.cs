/*
Напишите программу, которая на вход принимает число, 
а на выходе показывает сколько цифр у данного числа.
*/
Console.Clear();
Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine());
int Number(int A)
{
    int count = 1;
    if (A<0)
    {
        A*=-1;
    }
    while (A>9)
    {
        A/=10;
        count++;
    }
    return count;
}
Console.WriteLine(Number(A));
