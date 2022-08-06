//Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.

Console.WriteLine("Введите первое целое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое чило ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if(max < numberB)
{
    max = numberB;
}
Console.WriteLine("Большее число: " + max);
