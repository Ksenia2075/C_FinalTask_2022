// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых 
// меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// например:
// ["1234", "1567", "-2", "computer science"] -> ["-2"]

Console.Clear();
string[] arrayA = new string[6] {"1234", "1567", "-2", "computer science", "123", "cat"};
string[] arrayB = GetArrayB(arrayA);

PrintArray(arrayB);


// получаем новый массив где элемент <4
string[] GetArrayB(string[] array1)
{
    string[] array2 = new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length < 4) 
        array2[count] = array1[i];
        count++;
    }
    return array2;
}

// печатаем массив
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}

