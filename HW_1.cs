/*
Задание 1

Console.WriteLine("Введите два числа ");
int numberA = Convert.ToInt32 (Console.ReadLine());
int numberB = Convert.ToInt32 (Console.ReadLine());
if(numberA > numberB) Console.WriteLine( numberA);
else Console.WriteLine( numberB);
*/

/*
Задание 2

Console.WriteLine("Введите три числа");
int numberA = Convert.ToInt32 (Console.ReadLine()),
numberB = Convert.ToInt32 (Console.ReadLine()),
numberC = Convert.ToInt32 (Console.ReadLine()),
max = numberA;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.WriteLine("Максимальное число " + max);
*/

/* 
Задание 3

Console.WriteLine("Введите число");
int num = Convert.ToInt32 (Console.ReadLine()),
re = num % 2;
if (re > 0) Console.WriteLine(num + " нечетное число");
else Console.WriteLine (num + " четное число");
*/

/* 
Задание 4

Console.WriteLine("Введите число");
int num = Convert.ToInt32 (Console.ReadLine());
int current = 2;
if (num >= 2)
{
while (current <= num) 
{    
    Console.Write (current + " ");
    current = current +2;
}
}
else Console.WriteLine ("В этом числовом промежутке нет четных чисел");

*/