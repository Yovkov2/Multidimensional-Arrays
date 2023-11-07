int[] size = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = size[0];
int cols = size[1];

int[,] matrix = new int[rows, cols];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] tokens = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = tokens[j];
    }
}

int maxMatrix = int.MinValue;
int maxRow = 0;
int maxCol = 0;
for (int row = 0;row < rows-2; row++)
{
    for(int col = 0;col < cols-2; col++)
    {
        int currentMatrix = matrix[row,col] + matrix[row,col+1] + matrix[row,col+2]+
                            matrix[row+1,col] + matrix[row + 1,col + 1] + matrix[row+1,col+2]+matrix[row+2,col] + 
                            matrix[row+2,col+1] + matrix[row+2,col+2];
        if (currentMatrix > maxMatrix)
        {
            maxMatrix = currentMatrix;
            maxRow = row;
            maxCol = col;
        }
    }
}
Console.WriteLine($"Sum = {maxMatrix}");
for(int row = maxRow; row < maxRow+3; row++)
{
    for(int col = maxCol; col < maxCol+3; col++)
    {
        Console.Write($"{matrix[row, col]} ");
    }
    Console.WriteLine();
}
