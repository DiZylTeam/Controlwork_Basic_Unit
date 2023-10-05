string PromptString(string message)
{
    Console.WriteLine(message);
    string stringValue = Console.ReadLine()!;
    return stringValue;
}


string[] GetArray(string massage)  // метод для получения строкового массива
{
    string[] array = new string[1];  // объявляем новый массив

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = massage;
    }
    return array;
}


string Text(string[] arr) {     // метод для преобразования массива в строковый текст
    string text = "";  
    for (int i = 0; i < arr.Length; i++) {
            text = "";
            text += arr[i];
    }
    return text;
    }


string[] ResArray(string text)
{
    string[] array_2 = text.Split(' ');
    string[] finalArr = new string[array_2.Length];
    int j = 0;
    for (int i = 0; i < array_2.Length; i++)
    {  
        string word = array_2[i];
        if (word.Length <= 3)
        {
            finalArr[j] = word;
            j++;
        }   
    }
    return finalArr;
}


void PrintArray(string[] array)    // метод для вывода массива на экран
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"{array[array.Length - 1]}");    // вывод массива
}




string input = PromptString("Enter a text (words, numbers, symbols): ");
string[] inputArray = GetArray(input);
string text = Text(inputArray);
string[] resArray = ResArray(text);
PrintArray(resArray);
