// See https://aka.ms/new-console-template for more information
int i, m = 0;
Console.Write("Enter the numbers of an array: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), Int32.Parse);
for (i = 0; i < array.Length; i++)
{
if (array[i] > 0)
    {
        m++;
    }
}
Console.WriteLine($"Quantity of numbers that more than zero is {m}");