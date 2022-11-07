// Составить частотный словарь элементов двумерного массива
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.Clear();

// int cube = new Random().Next(6)+1;
// System.Console.WriteLine(cube);

int [] items = new int[6] {0,0,0,0,0,0};
double count = 1000000;
for (int i= 0; i< count; i++)
{
    int cube = new Random().Next(6);
    items[cube]++;// items[cube]= items[cube]+1
}
for (int i = 0; i< items.Length; i++)
{
    Console.WriteLine($"{i+1}: {items[i]/count*100}%");
    //Console.WriteLine($"{i+1}: {items[i]}");
}