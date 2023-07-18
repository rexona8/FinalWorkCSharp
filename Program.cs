// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void FindLessFour(string[] start, string[] finish)
{
    int count = 0;
    for (int i = 0; i < start.Length; i++)
    {
        if (start[i].Length <= 3)
        {
            finish[count] = start[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] stringArrStart = new string[4] { "“Hello”", "2", "“world”", ":-)" };
string[] stringArrFinish = new string[stringArrStart.Length];
FindLessFour(stringArrStart, stringArrFinish);
PrintArray(stringArrFinish);