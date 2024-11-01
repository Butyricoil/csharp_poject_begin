
class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[5, 5];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = 0;
            }
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, i] = 1;
            }
        }

        foreach (int i in array)
        {
            foreach (int j in array)
            {

            }
        }

    }
}
