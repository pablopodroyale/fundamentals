CalculateSumRecursively(1,3);

static int CalculateSumRecursively(int n, int m)
{
    int sum = n;
    if (n < m)
    {
        n++;
        return sum += CalculateSumRecursively(n, m);
    }
    Console.WriteLine(sum); 
    return sum;
}