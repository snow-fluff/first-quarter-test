// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Clear();

string[] arrayOfStrings = { "Уфа", "Белгород", "Москва", "СПб", "Екб", "Ульяновск", "УУ" };
int maxCountSymbols = 3;

string[] newArrayOfStrings = FillArrayMaxCount(arrayOfStrings);
Console.Write("[");
PrintArray(arrayOfStrings);
Console.Write("] -> [");
PrintArray(newArrayOfStrings);
Console.Write("]");

string[] FillArrayMaxCount(string[] arr)
{
    string[] newArr = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= maxCountSymbols)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != null)
        {
            Console.Write("\"" + arr[i] + "\" ");
        }
    }
}