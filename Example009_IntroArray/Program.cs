// использование метода (функции) для решения задачи нахождения максимума.  
// Вводим аргументы как массив

int Max(int arg1, int arg2, int arg3) //Объявление метода Max поиска максимума из 3-х аргументов
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
// объявляем массив
//индекс элемента   0   1   2   3   4   5  6   7   8
    int[] array = {11, 21, 831, 41, 51, 61, 17, 18, 19}; 

int max = Max(                         // поиск макс из максимумов трех троек
    Max(array[0], array[1], array[2]), // поиск макс в 1й тройке
    Max(array[3], array[4], array[5]), // поиск макс в 2й тройке
    Max(array[6], array[7], array[8]) // поиск макс в 3й тройке
);
Console.WriteLine(max);
