/*
Напишите программу, которая выводит массив из 8 элементов,
заполненный 0 и 1 в случайном порядке.
*/
Console.Clear();
int N = 8;
int [] MassRandom(int N)
{
    int [] mass = new int [N];
    Console.Write("[");
    for (int i=0; i<(N-1); i++)
    {
        mass[i] = new Random().Next(0,2);
        Console.Write($"{mass[i]},");
    }
    Console.Write($"{mass[(N-1)]}]");
    return mass;
}
int [] b = MassRandom (N);
