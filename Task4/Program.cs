﻿// Задача 4
// На вход принимаем число (number), а на выходе показываем все чётные числа от 1 до number(включительно),
// после каждого числа должен быть знак пробела.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if (number > 1)
{
    while (evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}