Console.Clear();

string text = "Употребление этого термина возможно только для тех национальных поэзий,"
            + "для которых и размер, и рифма являются характерными,"
            + "системообразующими признаками: так, применительно к древнегреческой поэзии,"
            + "в которой нечто похожее на рифму возникало разве что в виде исключения,";

string Replace(string text, char OldValue, char NewValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == OldValue) 
        {
            result = result + $"{NewValue}";
        }
        else 
        {
        result = result + $"{text[i]}";
        }
    
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
