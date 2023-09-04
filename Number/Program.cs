using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
/*адайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

void FillArray(double[] collection) {
    int index =0;
    int length = collection.Length;
    while(index<length) {
        collection[index] = double.Parse(Console.ReadLine());
        index++;
    }
}

void PrintArray(double[] col) {
    int count = 0;
    int len = col.Length;
    while(count<len) {
        Console.WriteLine(col[count]);
        count++;
    }
}


double[] arr = new double[5];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
double min =  arr[0];
double max = arr[0];
int j=0;
foreach (double arrs in arr) {
    if (arr[j]>max) {
        max  = arr[j];
    }
    if (arr[j]<min) {
        min = arr[j];
    }
    double diff = max-min;
    Console.WriteLine(diff);
    j++;
}




