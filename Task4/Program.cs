// Написать программу копирования массива
void PrintArray(int[] array)                     // вариант вывода на консоль массива
{
    Console.Write(String.Join(' ', array));
    Console.WriteLine();
}

int[] CopyArray(int[] array)
{


int[]arraycopy = new int[array.Length];
for (int i=0; i< arraycopy.Length; i++) 
    {
        arraycopy[i] = array[i];
    }
    return arraycopy;
}

int[]massiv = {1, 5, 6, 4, 7, 56, 54, 34};


int[] copymassiv = CopyArray(massiv);
PrintArray(copymassiv);

