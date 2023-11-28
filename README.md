##### Задача: ########
написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

## Описание методов ##

1. Метод CreateInitialArray() создает первичный строковый массив. Пользователем вводится количество строк. Если введено некорректное количество, выводится сообщение об ошибке. Далее при помощи цикла for, который соразмерен заданному количеству строк, пользователем заполняется каждый элемент массива. Для ввода каждой строки вызывается метод EnterParameters(string message).

2. Метод ArrayConversion(string[] array) принимает в качестве аргумента ранее созданный массив array. В этом методе создается еще один строковый массив intermediateArray с длиной, равной длине array. Так же создается переменная cell = 0, для счета элементов массива в array, которые меньше либо равны 3. При помощи цикла for перебирается массив array. Каждый элемент массива проверяется условием if - если длина элемента массива меньше либо = 3, то в cell элемент массива intermediateArray заносится строка i элемента array. Далее создается массив conversionArray длинной count, в который при помощи еще одного цикла for попорядку записываются все, уже отсортированные элементы из массива intermediateArray. 

3. Метод PrintArray(string[] array) выводит преобразованный массив в консоль.

## Вызов методов ##

В аргумент метода PrintArray(string[] array) передается метод ArrayConversion(string[] array), в котором в свою очередь в качестве аргумента выступает метод CreateInitialArray(). 
