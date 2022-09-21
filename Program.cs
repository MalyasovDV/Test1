
int[] SizeOfElements(string[] array)
{   
    int[] sizeArray = new int[array.Length];
    for (int i = 0; i < array.Length; ++i)
    {
             sizeArray[i] = array[i].Length;
    }
    return sizeArray;
}

string[] ResultArray(int[] sizeArray, string[] array)
{
    int count = 0;
    for (int i = 0; i < sizeArray.Length; ++i)
    {
        if (sizeArray[i] <= 3)
            ++count;
    }

    string[] result = new string[count];
    count = 0;

    for (int i = 0; i < sizeArray.Length; ++i)
        if (sizeArray[i] <= 3)
            result[count++] = array[i];
    
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; ++i)
    {
        Console.WriteLine("Элемент {0}: {1}", i, array[i]);
    }
}

Console.WriteLine("Введите размер массива");
int n = int.Parse(Console.ReadLine());

string[] array = new string[n];
string[] result;

Console.WriteLine();

Console.WriteLine("Введите элементы массива");

for (int i = 0; i < n; ++i)
{
    Console.WriteLine("Элемент {0}:", i);
    array[i] = Console.ReadLine();
}

Console.WriteLine();
result = ResultArray(SizeOfElements(array), array);

PrintArray(result);