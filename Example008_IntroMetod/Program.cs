﻿// использование метода (функции) для решения задачи нахождения максимума. 
// Напрмиер, есть три тройки игроков. В каждой тройке определяем макс результат, 
// затем определяем абсолютного победителя

//1я тройка игроков с их результатами
int a1 = 15;
int b1 = 25;
int c1 = 39;

//2я тройка игроков с их результатами
int a2 = 175;
int b2 = 225;
int c2 = 939;

//3я тройка игроков с их результатами
int a3 = 813;
int b3 = 23;
int c3 = 313;


int Max(int arg1, int arg2, int arg3) //Объявление метода Max поиска максимума из 3-х аргументов
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}

//вариант кода 1
/* int max1 = Max(a1, b1, c1); //вызов метода Max с передачей ему аргументов и получением результата - макс числа в 1й тройке
int max2 = Max(a2, b2, c2); //вызов метода Max с передачей ему аргументов и получением результата - макс числа в 2й тройке
int max3 = Max(a3, b3, c3); //вызов метода Max  с передачей ему аргументов и получением результата - макс числа в 3й тройке
int max = Max(max1, max2, max3); //вызов метода Max с передачей ему аргументов и получением результата - макс из максимумов всех троек
*/
//вариант кода 2
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));


Console.WriteLine(max);
