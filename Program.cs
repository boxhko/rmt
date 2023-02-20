
int num;

Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());



if (num%5==0 && num%3==0)
{
    Console.WriteLine("fizzbuzz");
}



else
{
    if (num%5==0)
    {
        Console.WriteLine("buzz");
    }
    if (num%3==0)
    {
        Console.WriteLine("fizz");
    }
}
