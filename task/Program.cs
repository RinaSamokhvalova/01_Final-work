// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

// Вариант решения - 3
// Решение оформлено в метод. Ввод данных - ввод с клавиатуры.

Console.Write("Задайте строковый массив (элементы массива вводите через ;): ");           // - ввод исходного одномерного массива 
string strLine = Console.ReadLine();
Console.Write("Введите параметр сортировки (максимальное число символов в строке): ");  // - ввод количества символов, критерий отбора элементов
int numberСharacters = int.Parse(Console.ReadLine() ?? "0");

string[] arrayA = strLine.Split(new char[] { ';' });                                    // - разделение строки на элементы массива
Console.WriteLine("Исходный массив:");
Console.WriteLine(String.Join(" ", arrayA));                                            // - вывод исходного массива

string[] arrayB = GetSelectionArray(arrayA, numberСharacters);          // - создание нового массива            
Console.WriteLine("Новый массив:");
Console.WriteLine(String.Join(" ", arrayB));                            // - вывод нового массива



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