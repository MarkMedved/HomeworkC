﻿Console.Clear();
int Fibonacci (int n)
{
    if (n==1 || n==2) return 1;
    else return Fibonacci (n-1)+Fibonacci (n-2);
}
for (int i =1; i<20; i++)
{
    Console.WriteLine($"{i}={Fibonacci(i)}");

}