// Из имеющегося массива строк сформировать массив, длина строк которого меньше или равна 3 символам.
using static System.Console;

Clear();
string[] array = { "x2", "Hello", "Monday", "17/238", "2", ":-)" };
PrintArray(array);
string[] arrayNew = new string[array.Length];
getArrayOf3Elements(array, arrayNew, 3);
arrayNew = arrayNew.Except(new List<string> { string.Empty }).ToArray();
PrintArray(arrayNew);




void getArrayOf3Elements(string[] array1, string[] array2, int maxLength)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= maxLength)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    WriteLine($"{inArray[inArray.Length - 1]}]");
}
