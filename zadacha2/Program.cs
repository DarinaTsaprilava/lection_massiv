 Random random = new Random();
int number = random.Next(100, 1000);
Console.WriteLine($"число {number}");

int a = number / 100;
int c = number % 10;
Console.WriteLine($"{a}{c}");
