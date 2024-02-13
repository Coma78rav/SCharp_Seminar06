// Задача 1:
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

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

