// Задача: Написать программу, 
// которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.WriteLine("Создайте исходный массив.");
Console.Write("Введите число строк в массиве: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
while (sizeArray <= 0)
{
    Console.WriteLine("Размер исходного массива задан некорректно. Попробуйте снова.");
    Console.Write("Введите число строк в массиве: ");
    sizeArray = Convert.ToInt32(Console.ReadLine());
}
if (sizeArray > 10)
{
    Console.WriteLine($"Число строк вашего массива {sizeArray}.");
    Console.WriteLine("Дальше программа вам предложит вводить каждую строку");
    Console.WriteLine("Уверены, что хотите вводить такой большой массив?");
    Console.WriteLine("Прошу повторно ввести размер массива, или изменить его.");
    Console.Write("Введите число строк в массиве: ");
    sizeArray = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите строки массива. Это может быть любой текст.");
string[] firstArray = FirstArrayOfString(sizeArray);
Console.WriteLine("Исходный массив");
PrintArray(firstArray);
string[] arrayOfShotString = ArrayOfShotString(firstArray);
Console.WriteLine("Массив из строк с длиной не более 3 символов:");
PrintArray(arrayOfShotString);

string[] ArrayOfShotString(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) size++;
    }
    string[] arrayOfString = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayOfString[j] = array[i];
            j++;
        }
    }
    return arrayOfString;
}

string[] FirstArrayOfString(int size)
{
    string a = string.Empty;
    string[] arrayOfString = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Строка  {i + 1}: ");
        a = Console.ReadLine();
        while (a.Length == 0)
        {
            Console.WriteLine("Вы ввели пустую строку. Попробуйте снова.");
            Console.Write($"Строка  {i + 1}: ");
            a = Console.ReadLine();
        }
        arrayOfString[i] = a;
    }
    return arrayOfString;
}

void PrintArray(string[] array)
{
    Console.Write("[`");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + "`, `");
        else Console.Write(array[i]);
    }
    Console.WriteLine("`]");
}
