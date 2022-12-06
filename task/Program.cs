// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

// Вариант решения - 2
// Решение оформлено в метод. Ввод данных - изначально заданные параметры.

// используем для старта набор данных из примера:
string[] arrayA = { "Hello", "2", "world", ":-)" };                     // - ввод исходного одномерного массива (массив взят из примера)
// string[] arrayA = { "1234", "1567", "-2", "computer science" };
// string[] arrayA = { "Russia", "Denmark", "Kazan" };
int numberСharacters = 3;                                               // - количество символов, критерий отбора элементов

Console.WriteLine("Исходный массив:");
Console.WriteLine(String.Join(" ", arrayA));                            // - вывод исходного одномерного массива

string[] arrayB = GetSelectionArray(arrayA, numberСharacters);          // - создание нового массива            
Console.WriteLine("Новый массив:");
Console.WriteLine(String.Join(" ", arrayB));

// Метод осздает новый массив на основе заданного, отсортировывая данные по заданной длинне строки
string[] GetSelectionArray(string[] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)          // считаем количество элементов в новом массиве
    {
        if (array[i].Length <= number)
        {
            count++;
        }
    }

    string[] res = new string[count];               // инициализация нового массива
    count = 0;
    for (int i = 0; i < array.Length; i++)          // заполнение нового массива
    {
        if (array[i].Length <= number)
        {
            res[count] = arrayA[i];
            count++;
        }
    }
    return res;
}