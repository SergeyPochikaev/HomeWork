# **Выполнения задач по семинарам "Введения в язык программирования в С#"**
## __I. Задачи реализованы стихийным методом__
---
## __*1. Задачи по 1-му семинару "Знакомство с языком программирования С#"*__
## 1. __Задача 2:__ Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.



~~~
Листинг программы С# по выполнению Задачи 2
~~~
[КОД](SpontaneousApproach\Task1_Finding_Max_and_Min_Number\Program.cs)  
[Блок-схема](https://github.com/SergeyPochikaev/HomeWork/tree/main/SpontaneousApproach/Task1_Finding_Max_and_Min_Number/diagram.drawio.png)



Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не
рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

__*Примеры:*__


 - [1, 2, 3, 4] -> [2, 4]
 * [1, 3, 4, 5, 7, 1, 3] -> [4]
+ [2, -4, 6] -> [2, -4, 6]
 * [1, 3, 5] -> []

## Решение:
 1. В первую очередь рисуем блок-схему:
![Block Diagram](block_diagram.jpg)
2. Пишем код на языке С#  в VS code
    
    1. Пишем метод создания нашего начального массива
        * _CreateArray_ - название метода
        * _count_ - количество чисел в массиве  
    2. Далее заполняем его, _в нашем случае, радномными числами от **-500** до **500**_, с помощью метода FillArray.
        * _FillArray_ - название метода заполнения массива
    Метод типа void, который принимает наш первоначальный массив, минимальное и макимальное значение диапозона, откуда  рандомно выберит значения для нашего массива. Метод void ничего не возвращает.  
    3. Создаем метод печати массива
        * _PrintArray_ название метода, подготавливает для вывода на экран наш первоначальный массива.
        * Метод принимает наш массив, выводит на экран все числа по порядку их индексов.
    4. А теперь нам нужно написать метод, который выберет из нашего массива только чётные числа и соберет их в новый маасив.
        * _EvenNumbers_ - название метода.
    с помощью цикла внутри метода, проверяем каждое число массива на четность, деля его на 2 и определяя остаток, если остаток равен 0, то число чётное. Чётное число добавляем в наш новый массив. Если число нечётное, то есть при делении на 2, остаток от деления не равен 0, то число не лобавляем в новый массив а переходим к спроверке следующего числа.
    5. Выше мы перечислили все методы для решения задачи. Теперь нам нужно вызвать все методы и получить результат.

        * **int[] array = CreateArray(10);** 
    создаем массив из 10 значений
        * **FillArray(array,-500,500);** 
    заполняем массив рандомными числами от -500 до 500.
        * **Console.WriteLine(PrintArray(array));** 
    печатаем начальный массив
        * **Console.WriteLine(PrintArray(EvenNumbers(array)));** 
    печатаем массив на основе первого, но только слстоящий из чётных числа

                  Задача решена!!!
