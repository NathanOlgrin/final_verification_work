int n, m=0, i;
Console.Write("Введите количество строк в массиве: ");
n = Int16.Parse(Console.ReadLine());
string[] array = new string[n];
for(i=0;i<n;i++)
{
    Console.Write($"Введите {i}-ю строку массива: ");
    array[i] = Console.ReadLine();
}

