# Итоговая контролная работа 1
## Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
```
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```

## Решение
1. Создаем два новых массива array и arraySort
2. В массив array будем класть N-ое количество элементов
3. Проверяем, если длина элемента массива array меньше 4, то присваиваем этот элемент массиву arraySort
4. Выводим массив arraySort.