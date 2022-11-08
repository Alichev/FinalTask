Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Описание решения:
Задаются 2 строковых массива: оригинальный (array) и резолютирующий (arrayNew), причем второй - той же длины, что и оригинальный.
Далее пишем метод, который принимает на вход оригинальный и резолютирующий (пока пустой) массивы, а также значение максимальной длины элемента массива (maxLength).
Метод проверяет значение каждого элемента массива на его длину (количество символов), если длина менее 4 символов - то этот элемент записывается в резолютирующий массив на следующую по очереди позицию, переменная count используется для формирования резолютирующего массива без пустых значений.
После использования метода для формирования резолютирующего массива применяем метод печати массива.