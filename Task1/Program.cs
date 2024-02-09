//Задача 1
// На вход принимаем два числа и выводим, какое число большее, а какое меньшее.

System.Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    System.Console.WriteLine("Первое число больше");
}
else if (firstNumber < secondNumber)
{
    System.Console.WriteLine("Второе число больше");
}
else
{
    System.Console.WriteLine("числа равны");
}