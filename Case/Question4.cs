
//using System;

//class LoximaxMatrix
//{
//    static int T = 4;


//    static void rotate90Clockwise(int[,] a)
//    {

//        for (int i = 0; i < T / 2; i++)
//        {
//            for (int j = i; j < T - i - 1; j++)
//            {


//                int temp = a[i, j];
//                a[i, j] = a[T - 1 - j, i];
//                a[T - 1 - j, i] = a[T - 1 - i, T - 1 - j];
//                a[T - 1 - i, T - 1 - j] = a[j, T - 1 - i];
//                a[j, T - 1 - i] = temp;
//            }
//        }
//    }

//    static void printMatrix(int[,] array)
//    {
//        for (int i = 0; i < T; i++)
//        {
//            for (int j = 0; j < T; j++)
//                Console.Write(array[i, j] + " ");
//            Console.Write("\n");
//        }
//    }

//    public static void Main()
//    {
//        int[,] array = {{1, 2, 3, 4},
//                  {5, 6, 7, 8},
//                  {9, 10, 11, 12},
//                  {13, 14, 15, 16}};
//        rotate90Clockwise(array);
//        printMatrix(array);
//    }
//}


//Arda KARAMAN