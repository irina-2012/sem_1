// вариант где нужно вводить данные самим
Console.WriteLine("введите два числа");
int a, b;
Console.WriteLine("Введите первое число");
a = Convert.ToInt32(Console.Read());

Console.WriteLine("Введите второе число");
b = Convert.ToInt32(Console.Read());

int max = a;

if(b > max) 
{
    max = b;
} 

Console.Write("max = ");
Console.WriteLine(max);
