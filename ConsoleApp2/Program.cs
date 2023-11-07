int size = int.Parse(Console.ReadLine());

int rows = size;
int cols = size;

int[,] matrix = new int[rows, cols];

int primarySum = 0;
int secondarySum = 0;

for (int row = 0; row < rows; row++)
{
    int[] tokens = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for(int col = 0; col < cols; col++)
    {
        matrix[row,col] = tokens[col];
    }
}

for(int row = 0;row < rows; row++)
{
    primarySum += matrix[row,row];
    secondarySum += matrix[rows-1-row,row];
}
Console.WriteLine(Math.Abs(primarySum-secondarySum));