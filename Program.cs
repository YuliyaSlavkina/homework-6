// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] ConvertStringToInt (string numbers){
      string[] numberStrings = numbers.Split(" ");
      int[] nums = new int[numberStrings.Length];
      for(int i = 0; i < numberStrings.Length; i++)
      {
      nums[i] = Convert.ToInt32(numberStrings[i]);
      }
      return nums;
    }

    void ShowArray(int[] array){
      for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
      }
    }

    int Counter (int[] array){
      int count = 0;
      for(int i = 0; i < array.Length; i++){
        if (array[i] < 0)
        count+=1;
      }
      return count;
    }
    

    

  Console.WriteLine("Enter your numbers separated by a space: ");
  string numbers = Console.ReadLine();
  int[] myArray = ConvertStringToInt(numbers);
  ShowArray(myArray);
  Console.WriteLine();
  Console.WriteLine($"The count of numbers less than zero: {Counter(myArray)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//  void Find (double k1, double b1, double k2, double b2){
//       double x = Math.Round(((b2 - b1) / (k1 - k2)),2);
//       Console.Write(x);
//       double y = Math.Round(((k2 * x) + b2),2);
//       Console.WriteLine ($"Пересечение в точке: ({x}; {y})");
      
//     }


//     Console.Write("Введите значение b1: ");
//     double b1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите значение k1: ");
//     double k1 = Convert.ToInt32(Console.ReadLine());
//      Console.Write("Введите значение b2: ");
//     double b2 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите значение k2: ");
//     double k2 = Convert.ToInt32(Console.ReadLine());
   

//     Find(k1,b1, k2, b2);