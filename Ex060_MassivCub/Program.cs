
Console.Clear();
int [] data ={1,2,4,6,9,18,10,50,0,0};
System.Console.WriteLine(Solve(data));
string Solve(int[] dataNumbers)
{
    if(dataNumbers.Length == 0) return "empty";
    string output = String.Empty;
    int max = dataNumbers[0];
    for(int i = 0; i<dataNumbers.Length; i++)
    {
        if(dataNumbers[i]>max) max = dataNumbers[i];
    }
    int[] result = new int[max+1];
    for (int i =0; i < dataNumbers.Length; i++)
    {
        int value = dataNumbers[i];
        result [value]++;
    }
        for (int i =0; i< result.Length; i++)
    {
        if (result[i]!=0)
        {
            output += $"{i} - {result[i]}p.\n";
        }
    }
    return output;
}