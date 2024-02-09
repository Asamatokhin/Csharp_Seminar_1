//Задача 2
//Принимаем на вход три числа и выдаём максимальное из этих чисел.

System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int result = 0;
if (a > result)
{
    result = a;
}
if (b > result)
{
    result = b;
}
if (c > result)
{
    result = c;
}
System.Console.WriteLine("Максимальное число: " + result);
