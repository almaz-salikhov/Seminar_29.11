﻿//На входе число N, а на выходн все четные числа от 1 до N?

Console.Write("Введите число больше нуля: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N < 0)
{
	Console.WriteLine("Введено отрицательное число, оно будет преобразовано");
    N = -N;
}
/*
for(int i = 2; i <= N; i = i + 2)
{
    Console.WriteLine(i);
}
*/
int i = 2;
while(i <= N)
{
	Console.Write(i + " ");
	i = i + 2;
}

Console.WriteLine();
