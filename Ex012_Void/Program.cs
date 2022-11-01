//Console.Clear();
//void Method1 (string msg)
//{
//    Console.WriteLine(msg);
//}
//Method1 ("Привет!");



Console.Clear();
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}  
    Method2("Good day!", 4);