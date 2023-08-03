/*Задача: Написать программу, которая из имеющегося массива строк
формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] ArrayInput(string[] arr) {
    Console.WriteLine("Введи строку с символами");
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = Console.ReadLine();
    }
    return arr;
}

int NumberOfRepetitions(string[] arr) {
    int k = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i].Length < 4) {
            k++;
        }
    }
    return k;
}
string[] ArraySort(string[] arr, int numrep) {
    string[] arrSort = new string[numrep];
    int j = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i].Length < 4) {
            arrSort[j] = arr[i];
            j++;
        }
    }
    return arrSort;
}

void ArrayPrint(string[] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++) {
            if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
            else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

string[] array = new string[4];

ArrayInput(array);
Console.WriteLine();
int numrep = NumberOfRepetitions(array);
string[] arraySort = ArraySort(array, numrep);
ArrayPrint(arraySort);