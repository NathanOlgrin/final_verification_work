int n, m=0, i;
Console.Write("Введите количество строк в массиве: ");
n = Int16.Parse(Console.ReadLine());
string[] array = new string[n];
for(i=0;i<n;i++)
{
    Console.Write($"Введите {i}-ю строку массива: ");
    array[i] = Console.ReadLine();
}

for(i=0;i<n;i++)
{
    if(array[i].Length<=3) m++;
}

string[] final_array = new string[m];
m=0;

for(i=0;i<n;i++)
{
    if(array[i].Length<=3)
    {
        final_array[m] = array[i];
    }
}
