void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.Write("Какое количество элементов необходимо ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
string[] newarray = new string[size];
int sym = 3;
int num = 0;
for (int i = 0; i < size; i++)
{
 Console.WriteLine($"Введите {i+1}-й элемент: ");
 string element = Convert.ToString(Console.ReadLine());
 if (element.Length <= sym)
    {
 newarray[num] = element;
 num++;
    }
}
Console.WriteLine();
ShowArray(newarray);