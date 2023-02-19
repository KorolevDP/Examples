// Type 1 ничего не принимает, но возвращает.

void Method1()
{
    Console.WriteLine("Autor KorolevDP");
}
//Method1();


// Type2 ничего не возвращает, но принимает аргументы.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Message text");

void Method2_1(string msg, int count)
{
    int i =0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method2_1(msg:"Message text", count: 4);


//Type 3 Что-то возвращают, но ничего не принимают.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);


//Type 4 Что-то принимают и что-то возвращают.

string Method4(int count, string text)
{
    string result = String.Empty;

    for(int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}

string res = Method4(10, "qwer");
//Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        //Console.WriteLine($"{i} x {j} = {i * j}");
    }
    //Console.WriteLine();
}  

//====== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы " к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, -что,"
            + "ежели бы ваc послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие пруcского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i< length; i++)
    {
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);
//Console.WriteLine();

newText = Replace(newText, 'к', 'К');
//Console.WriteLine(newText);
//Console.WriteLine();

newText = Replace(newText, 'С', 'с');
//Console.WriteLine(newText);


// Сортировка массива по возрастанию и по убыванию. Вложенные циклы.

int[]  arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray (int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortFromMinToMax(int [] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSortFromMaxToMin(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSortFromMinToMax(arr);
PrintArray(arr);
SelectionSortFromMaxToMin(arr);
PrintArray(arr);
