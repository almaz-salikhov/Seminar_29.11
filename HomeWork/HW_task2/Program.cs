﻿//  Программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел

int[] numbers = new int[3];

Console.Write ("Введите первое число: ");
numbers[0] = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число: ");
numbers[1] = int.Parse(Console.ReadLine());
Console.Write ("Введите третье число: ");
numbers[2] = int.Parse(Console.ReadLine());

int max = numbers[0]; //сразу присвоил max первому числу
int i = 1; //начинаю перебирать массив со второго, сравнивая с max 

while (i < 3)
{
	if(numbers[i] > max)
		max = numbers[i];
	i++;
}

Console.Write("Максимальное число из введенных: ");
Console.WriteLine(max);

