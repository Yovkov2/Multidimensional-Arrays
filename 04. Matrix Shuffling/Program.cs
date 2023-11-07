int[] size = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = size[0];
int cols = size[1];

string[,] matrix = new string[rows, cols];
for (int i = 0; i < rows; i++)
{
    string[] tokens = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for(int j = 0; j < cols; j++)
    {
        matrix[i,j] = tokens[j];
    }
}

string command = Console.ReadLine();
while(command != "END")
{
    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (tokens[0] == "swap" && tokens.Length == 5
        && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < rows
        && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < cols
        && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < rows
        && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < cols)
    {
        string tempValue = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
        matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
        matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = tempValue;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write($"{matrix[row, col]} ");
            }

            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
    command = Console.ReadLine();
}
