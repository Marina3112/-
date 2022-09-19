// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать старт выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись массивами.

//     Примеры:

//  ["hello","2", "world", ":-)"] -> ["2", ":-)"]
//  ["1234","1567", "-2", "computer science"] -> ["-2"]
//  ["Russia","Denmark", "Kazan"] -> []

string[] NewArrayByCondition(string[] arr, int size = 0, int index = 0)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) size++;
    }
    string[] newArr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[index] = arr[i];
            index++;
        }
    }
    return newArr;
}

string[] AddingNewValuesToArray(string[] arr, string newRow)
{
    string[] newArr = new string[arr.Length + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    newArr[newArr.Length - 1] = newRow;
    return newArr;
}

string[] InputArrayUser()
{
    string[] arr = new string[0];
    while (true)
    {
        Console.Write("Завершить - q. Введите элементы: ");
        string userInformation = Console.ReadLine()!;
        if (userInformation == "q" || userInformation == "Q") break;
        else arr = AddingNewValuesToArray(arr, newRow: userInformation);
    }
    return arr;
}

Console.WriteLine("Программа, которая принимает строки и возвращает те, длина которых меньше либо равна 3 символам.");
Console.WriteLine();

string[] information = InputArrayUser();
Console.WriteLine();
Console.WriteLine("[{0}] - введенные элементы", string.Join(", ", information));
Console.WriteLine();
string[] newInformation = NewArrayByCondition(arr: information);
Console.WriteLine("[{0}] - результирующий массив", string.Join(", ", newInformation));