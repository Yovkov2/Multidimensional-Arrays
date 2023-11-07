int[] size = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string word = Console.ReadLine();

int rows = size[0];
int cols = size[1];

char[,] matrix = new char[rows, cols];
int currentIndex = 0;
for (int i = 0; i < rows; i++)
{
    if (rows % 2 == 0)
    {
        for (int j = 0; j < cols; j++)
        {
            if(currentIndex == word.Length)
            {
                currentIndex = 0;
            }
            matrix[i, j] = word[currentIndex];
            currentIndex++;
        }
    }
    else
    {
        for (int j = cols - 1; j >= 0; j--)
        {
            if (currentIndex == word.Length)
            {
                currentIndex = 0;
            }
            matrix[i, j] = word[currentIndex];
            currentIndex++;
        }
    }
}
for(int i = 0;i < rows; i++)
{
    for(int j = 0;j < cols; j++)
    {
        Console.Write($"{matrix[i, j]}");
    }
    Console.WriteLine();

}
