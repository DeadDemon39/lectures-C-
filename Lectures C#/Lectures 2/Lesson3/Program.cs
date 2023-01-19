void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
   int count = collection.Length;
   int index = 0;
   int position = 0; // для того что бы число которое невозможно найти не падало на 0ю позицию нужно прописать так - int position = -1;

    while (index < count)
    {
        if(collection[index] == find) 
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);  // new Random().Next(1, 10)) решил попробовать и сработало)))
Console.WriteLine(pos);