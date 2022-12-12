// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
void summNumber(int numBig, int numSmall)
{
    if (numBig <= numSmall)
    {
        result += numBig;
        return;
    }
    else
    {
        result += numBig;
        summNumber(numBig - 1, numSmall);
    }
}

if (m >= n) summNumber(m, n);
else summNumber(n, m);
Console.WriteLine($"Result = {result}");


