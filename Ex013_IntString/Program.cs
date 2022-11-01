// Показывает год

//int Method3()
//{
//    return DateTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);


string Method4(string msg, int count)
{
    int i = 0;
    string result = String.Empty;
    while(i< count)
    {
        result = result + msg;
        i++;
}
return result;
}
string text = Method4("qw", 3);
Console.WriteLine(text);