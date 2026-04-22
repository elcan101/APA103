
//Taskın tələbi budur ki, ArrayResize metodu 2 parametr qəbul edəcək. 1-ci parametr hazır numbers array olacaq
//2-ci parametr ədədlər çoxluğu göndərib params ilə array kimi qəbul edəcəksiniz və method bu params ilə qəbul 
//etdiyiniz ədədləri numbers arrayinə əlavə edəcək.

using System.ComponentModel;

int[] numbers = new int[5];
int[] numbers2 = { 2, 5, 8, 11, 14 };
ArrayResize(ref numbers, numbers2);
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}


static void ArrayResize(ref  int[] numbers, params int[] numbers2)
{
    for (int i = 0; i < numbers2.Length; i++)
    {
        numbers[i] = numbers2[i];
    }
}

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = new int[5]; // İlkin massiv
//        int[] numbers2 = { 2, 5, 8, 11, 14, 20, 25 }; // Yeni elementlər (daha uzun ola bilər)

//        ArrayResize(ref numbers, numbers2);

//        // Nəticəni yoxlayaq
//        foreach (int num in numbers)
//        {
//            Console.WriteLine(num);
//        }
//    }

//    static void ArrayResize(ref int[] originalArray, int[] newElements)
//    {
//        // 1. Yeni ölçüdə massiv yaradırıq
//        int[] newArray = new int[newElements.Length];

//        // 2. Elementləri yeni massivə köçürürük
//        for (int i = 0; i < newElements.Length; i++)
//        {
//            newArray[i] = newElements[i];
//        }

//        // 3. Orijinal massivi yeni massivlə əvəz edirik (ref sayəsində)
//        originalArray = newArray;
//    }
//}