//Задача 3: 
//Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

// void inputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 11); //[1, 10]
// }

// void reverseArray(int[] array){
//     for (int i =0; i < array.Length / 2; i++){
//         int temp = array [i];
//         array[i] = array[array.Length - 1 - i]; // идем с конца массива до середины array.Length / 2
//         array[array.Length - 1 - i] = temp;
//     }
// }

// Console.Clear();
// System.Console.WriteLine("Введите кол-во элементов: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int [n];
// inputArray(array);
// System.Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// reverseArray (array);
// Console.WriteLine($"Перевернутый массив: [{string.Join(", ", array)}]");

// Задача 2: 
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// void inputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000); //[100, 999]
// }

// int countAdd(int[] array){
//     int count  = 0;
//     foreach (int element in array){
//         if (element % 2 == 0)
//         count++;
//     }
//     return count;
//     }


// Console.Clear();
// System.Console.WriteLine("Введите кол-во элементов: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int [n];
// inputArray(array);
// System.Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"колличество четных чисел массива: {countAdd(array)}");

// Задача 1:
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// bool sumCifr (string number){
//     int result = 0;
//     for (int i = 0; i < number.Length; i++){
//         result += int.Parse(number[i].ToString());
//     }
//     return result % 2 == 1;
// }

// Console.Clear();
// Console.WriteLine("Введите число; ");
// string number = Console.ReadLine()!;
// while (number != "q" || sumCifr(number)){
//     Console.WriteLine("Введите число; ");
//     number = Console.ReadLine()!;
// }

Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine()!;
int result = 0;
while (number != "q"){
result = 0;
for (int i = 0; i < number.Length; i++){
result += int.Parse(number[i].ToString());
}
if (result % 2 == 0){
number = "q";
}
else{
Console.Write("Введите число: ");
number = Console.ReadLine()!;
}
}