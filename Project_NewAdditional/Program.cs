// See https://aka.ms/new-console-template for more information
Int64 number;
string binary;
Console.Write("Enter any number: ");
number = Convert.ToInt64(Console.ReadLine());
binary = Convert.ToString(number, 2); // 2 - двоичная система исчисления. Программа может преобразовывать в другие системы исчисления в зависимости от введенного числа
Console.WriteLine($"Binary value of entered number is {binary}");