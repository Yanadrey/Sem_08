// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

int GetNumbers(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            matrix[i, j] = rand.Next(-10, 11);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            System.Console.Write(matrix[i, j] + "\t");
        System.Console.WriteLine();
    }
}

void OrderElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int maxJ = j;
            int temp = matrix[i, j];
            for (int k = j + 1; k < matrix.GetLength(1); k++)
                if (matrix[i, k] > matrix[i, maxJ])
                {
                    temp = matrix[i, maxJ];
                    matrix[i, maxJ] = matrix[i, k];
                    matrix[i, k] = temp;
                }
        }

}

int rows = GetNumbers("Введите количество строк матрицы: ");
int cols = GetNumbers("Введите количество столбцов матрицы: ");

int[,] myMatrix = GenerateMatrix(rows, cols);

PrintMatrix(myMatrix);
System.Console.WriteLine();
OrderElements(myMatrix);
PrintMatrix(myMatrix);
