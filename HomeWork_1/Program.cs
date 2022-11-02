Console.Write("Input a first number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number ");
int b = Convert.ToInt32(Console.ReadLine());

int max;
int min;

if(a > b)
{
    Console.WriteLine($"max = {a}");
    Console.WriteLine($"min = {b}");
}
else 
{
    Console.WriteLine($"max = {b}");
    Console.WriteLine($"min = {a}");
}