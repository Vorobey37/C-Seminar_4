/*
Напишите программу, которая на вход принимает число N,
а на выходе выдает произведение чисел от 1 до N.
*/
Console.Clear();
Console.WriteLine("Введите число:");
double N = double.Parse(Console.ReadLine());
double Factorial(double N)
{
    if (N<0)
    {
        N*=-1;
    }
    double F = 1;
    if (N==0)
    {
        F=0;
    }
    for (int i=1; i<=N; i++)
    {
        F*=i;
    }
    return F;
}
Console.WriteLine(Factorial(N));