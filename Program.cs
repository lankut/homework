//Задача №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
   Console.WriteLine("Большее число "+number1+" меньшее число "+number2);
if (number1<number2)
   Console.WriteLine("Большее число "+number2+" меньшее число "+number1);
if (number1==number2)
   Console.WriteLine("Числа равны");

//Задача №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max;
if (number1>number2)
   max = number1;   
else max = number2;
if (max<number3)
   max = number3;
Console.WriteLine("Максимальное число из трех цифр: "+max);

//Задача 6 Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2==0)
   Console.WriteLine("Число четное");
else 
   Console.WriteLine("Число нечетное");


//Задача 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int start = 1;

while (start <= number1)
{
   if (start % 2==0)
       Console.WriteLine(start);   
   start++;
}
