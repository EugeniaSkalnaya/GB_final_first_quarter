// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше string[] 
// array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] GivenArray = new string[] { "123", "23", "hello", "world", "res", "checklength", "=)" };

void FillNewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimit)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}

int ShortArrayLength(string[] array, int lengthLimit)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLimit) result++;
    }
    return result;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int lengthLimit = GetNumber("Введите длину-ограничитель элемента массива");
int numbersItems = ShortArrayLength(GivenArray, lengthLimit);

string[] newShortArray = new string[numbersItems];

FillNewArray(GivenArray, newShortArray, lengthLimit);
PrintArray(newShortArray);