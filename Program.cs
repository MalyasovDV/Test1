




Console.WriteLine("Введите размер массива");
int n = int.Parse(Console.ReadLine());

string[] array = new string[n];

Console.WriteLine("Введите элементы массива");

for (int i = 0; i < n; ++i)
{
    Console.WriteLine("Элемент {0}:", i);
    array[i] = Console.ReadLine();
}