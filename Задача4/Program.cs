// вариант где нужно вводить данные самим
int a, b;
int max = 0;
Console.WriteLine("введите два числа");

Console.WriteLine("Введите первое число");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
b = Convert.ToInt32(Console.ReadLine());

if(a > b) 
{
    max = a;
} 
else 
{
    max = b;
}
Console.Write("max = ");
Console.WriteLine(max);
