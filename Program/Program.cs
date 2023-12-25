// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
//----------------------------------------------------------------------------------
// Вариант 1(ввод с клавиатуры):
string[] ConvertToArray(string text)
{
    int l = text.Length;
    int count = 1;
    for (int i = 0; i < l; i++)
        if (text[i] == ' ')
            count++;
    string[] array = new string[count];
    count = 0;
    for (int i = 0; i < l; i++)
        if (text[i] == ' ')
            count++;
        else
            array[count] += text[i];
    return array;
}

Console.Write("Enter some words: ");
string text = Console.ReadLine()!;
string[] array = ConvertToArray(text);
// -------
// Вариант 2 (имеем разный размер элементов):
// string[] array = new string[] {"we", "all", "live", "in", "yellow", "submarin"};
// -------
// Вариант 3 (все элементы длиннее 3-х символов):
// string[] array = new string[] { "we_all", "live", "in_the", "yellow", "submarin" };
// -------
Console.WriteLine($"Первоначальный массив: [{string.Join(" ", array)}]");
int count = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i].Length < 4) count++;
if (count > 0)
{
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    Console.WriteLine($"Преобразованный массив: [{string.Join(" ", newArray)}]");
}
else Console.WriteLine("В первоначальном массиве все элементы длиннее 3-х символов");