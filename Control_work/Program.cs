// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символам. 
// Первоночальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());
string[] inputArray = new string[size];

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

FillArray(inputArray);
Console.WriteLine();
PrintArray(inputArray);
Console.WriteLine();

int CheckLimitArray(string[] array, int limit)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limit) count++;
    }
    return count;
}

int count = CheckLimitArray(inputArray, 3);
Console.WriteLine();
Console.WriteLine($"Количество элементов меньше или равно 3 символам = {count}");

string[] outputArray = new string[count];

string[] FillOutputArray(string[] onArr, string[] outArr, int limit)
{
    int temp = 0;
    for (int i = 0; i < onArr.Length; i++)
    {
        if (onArr[i].Length <= limit)
        {
            outArr[temp] = onArr[i];
            temp++;
        }
    }
    return outArr;
}

FillOutputArray(inputArray, outputArray, 3);
Console.WriteLine();
PrintArray(outputArray);