
int[] SizeOfElements(string[] array)
{   
    int count = 0;
    int[] sizeArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for(int symbol = 0; array[i][symbol] != '\0' ; ++symbol)
        {
            ++count;
        }
        sizeArray[i] = count;
        count = 0;
    }

    return sizeArray;
}

string[] ResultArray(int[] sizeArray, string[] array)
{
    int count = 0;
    for (int i = 0; i < sizeArray.GetLength(0); ++i)
    {
        if (sizeArray[i] <= 3)
            ++count;
    }

    string[] result = new string[count];
    count = 0;

    for (int i = 0; i < sizeArray.GetLength(0); ++i)
        if (sizeArray[i] <= 3)
            result[count++] = array[i];
    
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; array[i] != null; ++i)
    {
        Console.WriteLine("Элемент {0}: {1}", i, array[i]);
    }
}

Console.WriteLine("Введите размер массива");
int n = int.Parse(Console.ReadLine());

string[] array = new string[n];


Console.WriteLine("Введите элементы массива");

for (int i = 0; i < n; ++i)
{
    Console.WriteLine("Элемент {0}:", i);
    array[i] = Console.ReadLine();
}

PrintArray(ResultArray(SizeOfElements(array), array));