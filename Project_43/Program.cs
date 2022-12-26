// See https://aka.ms/new-console-template for more information
Console.Write("Enter b1 number: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k1 number: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2 number: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2 number: ");
var k2 = Convert.ToDouble(Console.ReadLine());
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
x = Math.Round(x, 2);
y = Math.Round(y, 2);
Console.WriteLine($"Point of intersection: ({x}; {y})");