//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Ввведите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Ввведите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Ввведите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = 0;

if( a > max ) max = a;
if(b > max ) max = b;
if( c > max ) max = c;

Console.WriteLine($"max = {max}");
