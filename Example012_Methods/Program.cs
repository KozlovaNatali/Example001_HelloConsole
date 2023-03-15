// Вид 1 - ничего не принимают, ничего не возращают

void Method1() // Метод
{
    Console.WriteLine("Автор ...");
}
Method1(); // вызов метода

// Вид 2 - что-то принимают, ничего не возвращают
void Method2(string msg) // Метод
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения"); // вызов метода

void Method21(string msg, int count) // Метод
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4); // вызов метода

// Вид 3 - ничего не принимают, что то возвращает

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 - что-то принимают, что-то возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);

// цикл в цикле

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}

// =====Работа с текстом=====
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К", 
// а большие "С" заменить маленькими "с".

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012345
// s[3] // r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replase(text, ' ', '-');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'C', 'c');
Console.WriteLine(newText);
Console.WriteLine();


// Сортировка массива от минималььного до максимального

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
       Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
       int minPosition = i;

       for(int j = i + 1; j < array.Length; j++)
       {
         if(array[j] < array[minPosition]) minPosition = j;
       }

       int temporrary = array[i];
       array[i] = array[minPosition];
       array[minPosition] = temporrary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
////////// 
// сортировка от максимального до минимального

int[] arr = { 1, 5, 4, 3, 2, 6, 7 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
       Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
       int maxPosition = i;

       for(int j = i + 1; j < array.Length; j++)
       {
         if(array[j] > array[maxPosition]) maxPosition = j;
       }

       int temporrary = array[i];
       array[i] = array[maxPosition];
       array[maxPosition] = temporrary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);