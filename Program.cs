Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];

for(int i = 0; i < n; i++)
{
    Console.Write($"Введите {i} элемент массива: ");
    array[i] = Console.ReadLine();
}

Console.Write("[ " + string.Join(", ",  array) + " ] -> [ ");
for(int i = 0; i < n; i++)
{
    if(array[i].Length <= 3)Console.Write($"{array[i]} ");
}

Console.WriteLine("]");