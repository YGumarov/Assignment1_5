static int Fibonacci(int n)
{
    int result;
    if (n == 1)
    {
        return 1;
    }
    if (n == 0)
    {
        return 0;
    }
    
    result = Fibonacci(n - 1) + Fibonacci(n - 2);
    return result;
    
}

int n = int.Parse(Console.ReadLine());
Console.WriteLine(Fibonacci(n));