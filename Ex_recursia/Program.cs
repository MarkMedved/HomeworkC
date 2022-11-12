Console.Clear();

int m = 2;
int n = 10;
int k = 1;
int q = 2;

int res = GetWays(m, n, k, q);

int GetWays(int m, int n, int k, int q, string text = " ")
{
    Console.WriteLine($"{m,3}{n,3}{k,3}{q,3}{text}");
    if (n < m) return 0;
    if (n == m) return 1;
    else if (n % q != 0) return GetWays(m, n - k, k, q, text + $"({n}-{k})");
    else return GetWays(m, n - k, k, q, text + $"({n} –– {k})") + GetWays(m, n / q, k, q, text + $"({n}➗{q})");
}
Console.WriteLine(res);