/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

void FillArray (int[] collection) {
    int index =0;
    int length = collection.Length;
    while (index<length) {
        collection[index]=new Random().Next(-100,100);
        index++;
    }
}

void PrintArray(int[] col) {
    int count = 0;
    int len = col.Length;
    while(count<len) {
        Console.WriteLine(col[count]);
        count++;
    }
}

int sum_nechet (int[] array) {
    int i = 0;
    int resualt = 0;
    int lent=array.Length;
    while (i<lent) {
        if (array[i]%2!=0) {
            resualt +=array[i];
        }
        i++;
    }
    return resualt;
}

int[] arr = new  int[5];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
int sumar = sum_nechet(arr);
Console.WriteLine(sumar);
