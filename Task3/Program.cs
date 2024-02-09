// Задача 3
// На вход принимаем число number и выводим, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remDiv = number % 2;

if(remDiv == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
