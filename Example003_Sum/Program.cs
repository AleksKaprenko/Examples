Console.Write("Введите первое целое число: ");
int numberA = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int numberB = Int32.Parse(Console.ReadLine());
int summary = numberA + numberB;
Console.WriteLine("Сумма введенных чисел равна " + summary);
Console.WriteLine();
Console.WriteLine("Часть 2. Сумма двух случайных чисел от 1 до 9");
int q = new Random().Next(1, 10); // 1,2,3...9
int t = new Random().Next(1, 10); // 1,2,3...9
int summary2 = q + t;
Console.WriteLine("Первое случайное число: " + q);
Console.WriteLine("Второе случайное число: " + t);
Console.WriteLine("Сумма двух случайных чисел = " + summary2);