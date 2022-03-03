using System;


class Rotate
{
    //Rotation of specific index in matrix 
    public static (int,int) GetRot90Index(int row, int column, int columnsOut)
    {
        return (column, columnsOut - 1 - row);
    }
    //Rotation of whole matrix 
    static int[,] Rotate90Clockwise(int[,] a)
    {
        var rows = a.GetLength(0);
        var colsA = a.GetLength(1);
        var b = new int[colsA, rows];
        var colsB = b.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colsA; j++)
            {
                b[j, colsB - 1 - i] = a[i, j];
            }
        }
        return b;
    }

    static void PrintMatrix(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
                Console.Write(arr[i, j] + " ");
            Console.Write("\n");
        }
    }

    //Testing it out
    public static void Main()
    {
        int[,] arr = {{1, 2, 3, 4, 5},
                  {6, 7, 8, 9, 10},
                  {11, 12, 13, 14,15},
                  {16,17,18,19,20}};
        //int[,] arr = {{1, 2},
        //          {6, 7},
        //          {11, 12},
        //          {16,17}};
        PrintMatrix(arr);

        var rotArr = Rotate90Clockwise(arr);
        Console.WriteLine();
        Console.WriteLine(GetRot90Index(1, 3, 4));
        Console.WriteLine();
        Console.WriteLine();
        PrintMatrix(rotArr);

        rotArr = Rotate90Clockwise(rotArr);
        
        Console.WriteLine();
        Console.WriteLine();
        PrintMatrix(rotArr);

        Console.ReadKey();
    }
}