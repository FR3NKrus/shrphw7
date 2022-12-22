// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] Creat2dArray(int rows, int cols, int min, int max){
    double [,] array = new double [rows,cols];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < cols; j++){
            array[i,j] = Convert.ToDouble(new Random().Next(min*100, max*100)/100.0);
        }    
    }
    return array;
}

void Show2dArray(double [,] array) {
      for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }    
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите мин значение: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите макс значение: ");
int max = Convert.ToInt32(Console.ReadLine());

double [,] newArray = Creat2dArray(rows, cols, min, max);
Show2dArray(newArray);

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int [,] Creat2dArray(int rows, int cols, int min, int max){
//     int [,] array = new int [rows,cols];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < cols; j++){
//             array[i,j] = Convert.ToInt32(new Random().Next(min, max));
//         }    
//     }
//     return array;
// }

// void Show2dArray(int [,] array) {
//       for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]}  ");  
//         }    
//         System.Console.WriteLine();
//     }
// }

// void ShowIndex(int x, int y, int [,] array){
//     Console.Write($"На позиции: {x},{y} находится число: {array[x-1,y-1]} ");
// }

// System.Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите мин значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите макс значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] newArray = Creat2dArray(rows, cols, min, max);
// Show2dArray(newArray);

// System.Console.Write("Введите номер строки: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите номер столбца: ");
// int y = Convert.ToInt32(Console.ReadLine());
//   while (x > newArray.GetLength(0) || y > newArray.GetLength(1)){
//           Console.WriteLine($"Такого числа в массиве нет! Макc. строк: {newArray.GetLength(0)}, столбцов:  {newArray.GetLength(1)}");    
//           Console.WriteLine($"Повторите ввод");  
//           System.Console.Write("Введите номер строки: ");
//           x = Convert.ToInt32(Console.ReadLine());
//           System.Console.Write("Введите номер столбца: ");
//           y = Convert.ToInt32(Console.ReadLine());
//       }
// ShowIndex(x, y, newArray);

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

  // int [,] Creat2dArray(int rows, int cols, int min, int max){
  //     int [,] array = new int [rows,cols];
  //     for (int i = 0; i < rows; i++){
  //         for (int j = 0; j < cols; j++){
  //             array[i,j] = Convert.ToInt32(new Random().Next(min, max));
  //         }    
  //     }
  //     return array;
  // }
    
  // double [] AverageArray(int [,] array){
  //   double [] avrArray = new double [array.GetLength(0)];
  //   for (int i = 0; i < array.GetLength(0); i++){
  //     for (int j = 0; j < array.GetLength(1); j++){
  //       avrArray[j] += array[i,j];
  //     }
  //   }
  //   return avrArray;
  // }

  // void ShowAvrArray(double [] array){
  //   for (int i = 0; i < array.Length; i++){
  //       Console.Write($"{Math.Round(array[i] / array.Length, 1)} ");  
  //   }
  // }
    
  // void Show2dArray(int [,] array) {
  //       for (int i = 0; i < array.GetLength(0); i++){
  //         for (int j = 0; j < array.GetLength(1); j++){
  //             Console.Write($"{array[i,j]}  ");  
  //         }    
  //         System.Console.WriteLine();
  //     }
  // }
  
  // System.Console.Write("Введите количество строк: ");
  // int rows = Convert.ToInt32(Console.ReadLine());
  // System.Console.Write("Введите количество столбцов: ");
  // int cols = Convert.ToInt32(Console.ReadLine());
  // System.Console.Write("Введите мин значение: ");
  // int min = Convert.ToInt32(Console.ReadLine());
  // System.Console.Write("Введите макс значение: ");
  // int max = Convert.ToInt32(Console.ReadLine());
  
  // int [,] newArray = Creat2dArray(rows, cols, min, max);
  // Show2dArray(newArray);
  // double [] avrArray = AverageArray(newArray);
  // ShowAvrArray(avrArray);

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
