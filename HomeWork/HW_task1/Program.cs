// Программа, которая на вход принимает два числа и выдает, какое большее, а какое меньшее.
Console.Write ("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine()); 

if(a > b) 
{
    int max = a; int min = b;
    Console.Write("Максимальное из двух: ");
    Console.WriteLine(max);
    Console.Write("Минимальное из двух: ");
    Console.WriteLine(min);
}
else
{
    int max = b; int min = a;
    Console.Write("Максимальное из двух: ");
    Console.WriteLine(max);
    Console.Write("Минимальное из двух: ");
    Console.WriteLine(min);
}
