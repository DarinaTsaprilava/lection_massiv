/*напишите программу, которая на вход принимает 2 числа и выводит, является ли первое число кратным второму.
если число 1 не кратно второму, выводится остаток от деления 
*/
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());


if (a % b == 0)
    Console.WriteLine($"{a},{b} -> кратно");
else
{
    Console.WriteLine($"{a},{b} -> не кратно");
    Console.WriteLine(a % b);
}
