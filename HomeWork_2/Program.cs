Console.Write("Input first number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number ");
int c = Convert.ToInt32(Console.ReadLine());

int max;

if(a > b)
{
    max = a;
}
else
{
    max = b;
}
if(c > max);
{
    max = c;
}
Console.WriteLine($"Max number {max}");
