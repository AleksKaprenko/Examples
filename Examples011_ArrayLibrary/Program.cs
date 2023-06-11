void FillArray(int[] collection) // void - если метод ничего не возвращает.
{
    int length = collection.Length; // длина массива
    int index = 0; // установить маркер элементов массива в позицию 0
    while (index < length)
    {
        collection[index] = new Random().Next(1, 12); // присвоить элементу произвольное значение от 1 до 11
        index++;
    }
}

void PrintArray(int[] col) // объявление метода распечатки массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int IndexOf(int[] collection, int find) // объявление метода поиска в массиве элемента со значением find
{
    int count = collection.Length;
    int index = 0;
//  int position = 0; // вызывает проблему: если ищем несуществующий элемент - выдает его как позицию 0
    int position = -1; // решение этой проблемы - при поиске несуществующего элемента выдаст его позицию как -1, что можно в дальнейшем обрабатывать
    while (index < count)
    {
        if(collection[index]==find)
        {
            position = index;
            break; // прервать после первого обраруженного, без этого будет выдавать последний обнаруженный элемент
        }
        index++;
    }
    return position;
}
int[] array = new int[12]; // объявление массива из 10 элементов

FillArray(array); // вызов метода - заполнить массив
PrintArray(array); // вызов метода - распечатать массив
Console.WriteLine();
int element = -4;
int pos = IndexOf(array, element);
if (pos >=0) Console.WriteLine(pos);
else Console.WriteLine($"Элемент {element} в массиве не существует");
