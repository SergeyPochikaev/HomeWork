# **Выполнения задач по семинарам "Введения в язык программирования в С#"**
## __I. Задачи реализованы стихийным методом__
---
## __*1. Задачи по 1 семинару "Знакомство с языком программирования С#"*__
~~~
Задачи и их способы решения по Семинару 1 указаны в табл.№1
~~~
## __*Табл.№1 - Задачи по 1-му семинару*__
|__*№*__|__*Наименование*__|__*Условия задачи*__|__*Комментарии*__|__*Приложение*__|
|:-----:|:----------------:|:------------------:|:---------------:|:--------------:|
|*1*|*Задача 2*|*Напишите программу, которая на вход принимает два числа и  выдаёт, какое число большее, а какое меньшее*|__*Пример:*__ a = 5; b = 7 -> max = 7 |[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/Task1_Finding_Max_and_Min_Number/Program.cs) [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/Task1_Finding_Max_and_Min_Number/diagram.drawio.png)| 
|*2*|*Задача 4*|*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел*|__*Пример:*__ 2, 3, 7 -> 7|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/Task2_Determining_Max_of_3_Number/Program.cs) [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/Task2_Determining_Max_of_3_Number/diagram.drawio.png)|
|*3*|*Задача 6*|*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)*|__*Пример:*__ 4 -> да|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/Task3_Even_or_Odd_Number/Program.cs) [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/Task3_Even_or_Odd_Number/diagram.drawio.png)|
|*4*|*Задача 8*|*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N*|__*Пример:*__ 5 -> 2, 4|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/Task4_Determines_only_Even_Numbers/Program.cs) [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/Task4_Determines_only_Even_Numbers/diagram.drawio.png)|
---
## __*2. Задачи по 2 семинару "Базовые алгоритмы"*__
~~~
Задачи и их способы решения по Семинару 2 указаны в табл.№2
~~~
## __*Табл.№2 - Задачи по 2-му семинару*__
|__*№*__|__*Наименование*__|__*Условия задачи*__|__*Комментарии*__|__*Приложение*__|
|:-----:|:----------------:|:------------------:|:---------------:|:--------------:|
|*1*|*Задача 10*|*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа*|*Установлены условия деления в остатках mod (через оператор %) и целочисленного деления div (через оператор / двух целых чисел тип переменных int)* __*Пример:*__ 456->5; 782->8; 918->1|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/BasicAlgorithms/Task1_Output_2_Number_from_3digit/Program.cs) и [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/BasicAlgorithms/Task1_Output_2_Number_from_3digit/diagram.drawio.png)| 
|*2*|*Задача 13*|*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет*|__*Пример:*__ 645->5; 78->Такой цифры нет; 32679->6|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/BasicAlgorithms/Task2_Output_3_Number_from_Any_Integer/Program.cs) и [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/BasicAlgorithms/Task2_Output_3_Number_from_Any_Integer/diagram.drawio.png)|
|*3*|*Задача 15*|*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным*|__*Пример:*__ 6->да; 7->нет; 1->нет|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/BasicAlgorithms/Task3_Numbers_Indicating_Day_of_Week/Program.cs) и [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/BasicAlgorithms/Task3_Numbers_Indicating_Day_of_Week/diagram.drawio.png)|
---
## __II. Задачи реализованы процедурным методом__
---
## __*1. Задачи по 3 семинару "Базовые алгоритмы (Продолжение)"*__
~~~
Задачи и их способы решения по Семинару 3 указаны в табл.№1
~~~
## __*Табл.№1 - Задачи по 3-му семинару*__
|__*№*__|__*Наименование*__|__*Условия задачи*__|__*Комментарии*__|__*Приложение*__|
|:-----:|:----------------:|:------------------:|:---------------:|:--------------:|
|*1*|*Задача 19*|*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом*|*Требуется доработка метода **CheckOnPalindrome** с добавлением условия вывода расширенного текста bool операции (см. примечание *)* __*Пример:*__ 14212 -> нет;12821 -> да|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/ProceduralApproach/Task1_Definition_of_Palindrome_from_5digits/Program.cs) и [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/ProceduralApproach/Task1_Definition_of_Palindrome_from_5digits/diagram.drawio.png)| 
|*2*|*Задача 21*|*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве*|__*Пример:*__ A (3,6,8); B (2,1,-7), -> 15.84|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/ProceduralApproach/Task2_Find_Distance_between_Points/Program.cs) и [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/ProceduralApproach/Task2_Find_Distance_between_Points/diagram.drawio.png)|
|*3*|*Задача 23*|*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N*|__*Пример:*__ 3 -> 1, 8, 27|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/ProceduralApproach/Task3_Input_Numbers_Outputs_Table_of_Cubes/Program.cs) и [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/ProceduralApproach/Task3_Input_Numbers_Outputs_Table_of_Cubes/diagram.drawio.png)|
---
__* Примечание:__
```c#
InputCondition();
long n = Convert.ToInt64(Console.ReadLine());
if (CheckOnPalindrome(n)) Console.WriteLine($"Число n = {n} является палиндромом");
else Console.WriteLine($"Число n = {n} не является палиндромом");
```
## __*2. Задачи по 4 семинару "Функции"*__
~~~
Задачи и их способы решения по Семинару 3 указаны в табл.№2
~~~
## __*Табл.№2 - Задачи по 4-му семинару*__
|__*№*__|__*Наименование*__|__*Условия задачи*__|__*Комментарии*__|__*Приложение*__|
|:-----:|:----------------:|:------------------:|:---------------:|:--------------:|
|*1*|*Задача 777*|*Напишите программу, которая выводит массив из N элементов, заполненный нулями и единицами в случайном порядке, но с 1-м элементом массива равным значением 1, а также реализовать перевод двоичного числа (созданного массива) в десятичное*|*При сокращении клиентского кода некорректно выдает значения массива и перевода в десятичное число (см. примечание *)* __*Пример:*__ 111000 -> 56|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/ProceduralApproach/Functions/Task1_CreatArray_of_Bit_with_TranslateDecimal_and_Versa/Program.cs) и [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/ProceduralApproach/Functions/Task1_CreatArray_of_Bit_with_TranslateDecimal_and_Versa/diagram.drawio.png)| 
|*2*|*Задача 27*|*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе*|__*Пример:*__ 452 -> 11|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/ProceduralApproach/Functions/Task2_DefinesSum_in_Numder/Program.cs) и [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/ProceduralApproach/Functions/Task2_DefinesSum_in_Numder/diagram.drawio.png)|
---
__* Примечание:__
```c#
int n = GetNumberByUser("");
Console.WriteLine(GoodPrint(CreateArrayBin(n), ConvertArrayBitOnDecimal(CreateArrayBin(n))));
```
## __III. Задачи по одномерному массиву__
---
## __*1. Задачи по 5 семинару "Функции и одномерные массивы"*__
~~~
Задачи и их способы решения по Семинару 5 указаны в табл.№1
~~~
## __*Табл.№1 - Задачи по 5-му семинару*__
|__*№*__|__*Наименование*__|__*Условия задачи*__|__*Комментарии*__|__*Приложение*__|
|:-----:|:----------------:|:------------------:|:---------------:|:--------------:|
|*1*|*Задача 37*|*Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве*|*Требуется реализовать как минимум 3-мя методами*|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/ArrayOneDimensional/Task1_Multiplication_of_Pairs_of_Numbers/Program.cs) и [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/ArrayOneDimensional/Task1_Multiplication_of_Pairs_of_Numbers/diagram.drawio.png)|
---
## __*2. Задачи по 6 семинару "Одномерные массивы. Продолжение"*__
~~~
Задачи и их способы решения по Семинару 5 указаны в табл.№2
~~~
## __*Табл.№2 - Задачи по 6-му семинару*__
|__*№*__|__*Наименование*__|__*Условия задачи*__|__*Комментарии*__|__*Приложение*__|
|:-----:|:----------------:|:------------------:|:---------------:|:--------------:|
|*1*|*Задача 41*|*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*|__*Пример:*__ 0,7,8,-2,-2 -> 2; 1,-7,567,89,223 -> 3|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/ArrayOneDimensional/Continuation/Task1_InputNumbers_OutputCountMoreZero/Program.cs) и [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/ArrayOneDimensional/Continuation/Task1_InputNumbers_OutputCountMoreZero/diagram.drawio.png)|
|*2*|*Задача 43*|*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*|__*Пример:*__ b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/ArrayOneDimensional/Continuation/Task2_PointIntersection_of_2_StraightLines/Program.cs) и [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/ArrayOneDimensional/Continuation/Task2_PointIntersection_of_2_StraightLines/diagram.drawio.png)|
---
## __IV. Задачи по двухмерному массиву__
---
## __*1. Задачи по 7 семинару "Двухмерные массивы"*__
~~~
Задачи и их способы решения по Семинару 7 указаны в табл.№1
~~~
## __*Табл.№1 - Задачи по 7-му семинару*__
|__*№*__|__*Наименование*__|__*Условия задачи*__|__*Комментарии*__|__*Приложение*__|
|:-----:|:----------------:|:------------------:|:---------------:|:--------------:|
|*1*|*Задача 47*|*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами*|__*Пример:*__ m = 3, n = 4|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/ArrayTwoDimensional/Task1_Matrix_with_Random_Numbers/Program.cs) и [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/ArrayTwoDimensional/Task1_Matrix_with_Random_Numbers/diagram.drawio.png)|
|*2*|*Задача 50*|*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет*|__*Пример:*__ Например, задан 2-х мерный массив, где указывает значения или такого элемента в массиве нет|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/ArrayTwoDimensional/Task2_Guess_Position_in_Matrix_Get_Number/Program.cs) и [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/ArrayTwoDimensional/Task2_Guess_Position_in_Matrix_Get_Number/diagram.drawio.png)|
|*3*|*Задача 52*|*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце*|__*Пример:*__ Например, задан 2-х мерный массив, где указывает Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.|[КОД](https://github.com/SergeyPochikaev/HomeWork/tree/main/ArrayTwoDimensional/Task3_ArithmeticMean_of_EachColumn_in_Matrix/Program.cs) и [Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/ArrayTwoDimensional/Task3_ArithmeticMean_of_EachColumn_in_Matrix/diagram.drawio.png)|
---