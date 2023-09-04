/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

void FillArray (int[] array) {
    int index = 0;
    int length = array.Length;
    while (index<length) {
        array[index] = new Random().Next(0,1000);
        index++;
    }
    int resualt = 0;
}
void PrintArray(int[] collection) {
    int len = collection.Length;
    int ind = 0;
    while (ind<len) {
        Console.WriteLine(collection[ind]);
        ind++;
    }
}

int chet (int[] arr) {
    int resualt = 0;
    int count = 0;
    if (arr[count]%2==0){
        resualt ++;
        count++;
    }
    return resualt;
}

int[] array = new int [10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int finish = chet(array);
Console.WriteLine(finish);

