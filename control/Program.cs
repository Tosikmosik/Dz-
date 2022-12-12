//задаю массив строк
string[] array = { "Russia", "2", "world", ":-)", "-2", "3", "12", "Git" };

//объявляю метод создания массива строк длинной 3+ символа
string[] CreateArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count += 1;
        }
    }
    string[] array = new string[count];
    {
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                array[j] = arr[i];
                j += 1;
            }
        }
    }
    return array;
}
//объявляю метод печати массива
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
//вывожу массив
string[] arrayResult = CreateArray(array);
PrintArray(arrayResult);