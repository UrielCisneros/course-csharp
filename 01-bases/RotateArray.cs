

partial class Program
{
    static void RunRotate()
    {
        RotateArray(new object[][]
        {
            new object[] {1, 2, 3},
            new object[] {4, 5, 6},
            new object[] {7, 8, 9}
        });
    }

    //input [[1, 2, 3],
    //       [4, 5, 6],
    //       [7, 8, 9]]


    //output [[7, 4, 1],
    //        [8, 5, 2],
    //        [9, 6, 3]]


    static void RotateArray<T>(T[][] array)
    {
        if (array.Length <= 0)
        {
            PrintLine("Array vacio");
            return;
        }

        SeparatorTitle("Input Array");
        PrintArray(array);


        int rows = array.Length;      // 3 filas
        int cols = array[0].Length;   // 3 columnas

        // Se inicializa el array rotado con las dimensiones intercambiadas
        T[][] rotatedArray = new T[cols][];

        // Se inicializa el array de cada fila
        for (int i = 0; i < cols; i++)
        {
            rotatedArray[i] = new T[rows];
        }

        //Se rota el array original 90 grados en sentido horario
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                rotatedArray[j][rows - 1 - i] = array[i][j];
            }
        }

        // Se imprime el array rotado
        SeparatorTitle("Rotated Array");
        PrintArray(rotatedArray);
    }

    static void PrintArray<T>(T[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

}

