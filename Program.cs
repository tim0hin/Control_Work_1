// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры
// или задать на старте выполнения алгоритма.

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i]} ");
    
    Console.WriteLine();
}

int CountOfSubstrings(string[] array, int lengthSearch)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthSearch)
            count++;
    }

    return count;
}

void CreateArraySubstrings(string[] arrayString, int lengthSearch)
{
    int substringArrayLength = CountOfSubstrings(arrayString, lengthSearch);
    string[] substringArray = new string[substringArrayLength];
    int indexSubstring = 0;

    for (int i = 0; i < arrayString.Length; i++)
    {
        if (arrayString[i].Length <= lengthSearch)
        {
            substringArray[indexSubstring] = arrayString[i];
            indexSubstring++;
        }
    }

    PrintArray(substringArray);
}

string[] arrayString = {"this", "is", "my", "control", "work", "!!!"};
int lengthSearch = 3;

System.Console.WriteLine("Первоначальный массив:");
PrintArray(arrayString);

System.Console.WriteLine();
System.Console.WriteLine("Массив строк, длина которых меньше или равна 3 символа:");
CreateArraySubstrings(arrayString, lengthSearch);
