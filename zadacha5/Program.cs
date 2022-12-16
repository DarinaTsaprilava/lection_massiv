/* Принимает на вход два числа и проверяет, является ли одно число квадратом второго
*/ 

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число");
int b = Convert.ToInt32(Console.ReadLine());

if(b % a == 0)
Console.WriteLine($"{a} является квадратом {b}");
else
Console.WriteLine($"{a} не является квадратом {b}");

