# Задача

*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.   
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.   
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

*Примеры:  
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]  
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]  
[“Russia”, “Denmark”, “Kazan”] → []*


# Описание решения задачи

1. Создаем локальный возвращаемый метод **PromptString** для получения от пользователя строковых данных.  
Пользователь вводит с клавиатуры произвольный текст, состоящий из любых значений (слова, буквы, цифры, символы). Функционал *Console.ReadLine()* считывает введенные пользователем данные.

```
                string PromptString(string message)
                {
                    Console.WriteLine(message);
                    string stringValue = Console.ReadLine()!;
                    return stringValue;
                }
```

2. Создаем возвращаемый метод **GetArray** преобразования введенных пользователем данных в строковый массив.

```
                string[] GetArray(string massage)
                {
                    string[] array = new string[1];

                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = massage;
                    }
                    return array;
                }
```

3. Создаем возвращаемый метод **Text**, позволяющий преобразовать полученный массив в строку типа *string*.  
Задаем пустую переменную *text* типа *string* , далее с помощью цилка *for* проходим по массиву и присваиваем переменной *text* значения, содержащиеся в массиве.

```
                string Text(string[] arr)
                {
                    string text = "";  
                    for (int i = 0; i < arr.Length; i++) {
                            text = "";
                            text += arr[i];
                    }
                    return text;
                }

```

4. Создаем возвращаемый метод **ResArray** для итогового решения задачи и получения нового массива из строк, длина которых меньше, либо равна 3 символам.
Внутри метода с помощью функционала *Split* разделяем полученные строки на отдельные строковые значения (слова, цифры, символы) по разделителю - пробел, и помещаем данные слова в новый массив *array_2* (для того, чтобы каждое отдельное значение имело свой индекс).  
Задаем новый пустой массив *finalArr*, куда будем складывать итоговые значения.  
Далее с помощью цикла *for* проходимся по массиву *array_2*.  
Внутри цикла задаем пустую переменную *word* типа *string*, которой при каждом очередном проходе присваиваем значение каждого элемента массива.  
С помощью условного оператора *if* проверяем каждое значение *word* на длину меньше либо равной *3*.
Если условие выполняется - помещаем данное значение в массив *finalArr*.

```
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
```

5. Создаем void метод **PrintArray** для вывода получаемых данных на консоль (печать).

```
                void PrintArray(string[] array)
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        Console.Write($"{array[i]} ");
                    }
                    Console.Write($"{array[array.Length - 1]}");
                }
```

6. Обращаемся к вышесозданным методам для их исполнения и выводим полученный результат на консоль (печать).

```
                string input = PromptString("Enter a text (words, numbers, symbols): ");
                string[] inputArray = GetArray(input);
                string text = Text(inputArray);
                string[] resArray = ResArray(text);
                PrintArray(resArray);
```
