using System;
using System.Text;

namespace Task7AllPathsInMatrix
{
    class AllPathsInMatrix
    {
        public static char[,] labyrith = new char[,]
        {
            { '_', '_', '_', '*', '_', '_', '_' },
            { '*', '*', '_', '*', '_', '*', '_' },
            { '_', '_', '_', '_', '_', '_', '_' },
            { '_', '*', '*', '*', '*', '*', '_' },
            { '_', '_', '_', '_', '_', '_', 'e' },
        };

        public static StringBuilder sb = new StringBuilder();

        static void Main()
        {
            FindAllPaths(0, 0);
            Console.Write(sb.ToString());
        }
        public static void FindAllPaths(int row, int col)
        {

            if (row < 0 || row >= labyrith.GetLength(0))
            {
                return;
            }
            if (col < 0 || col >= labyrith.GetLength(1))
            {
                return;
            }
            if (labyrith[row, col] == '*' || labyrith[row, col] == '1')
            {
                return;
            }
            if (labyrith[row, col] == 'e')
            {
                SavePath();
                return;
            }

            labyrith[row, col] = '1';

            FindAllPaths(row, col + 1); // Move right
            FindAllPaths(row + 1, col); // Move down
            FindAllPaths(row - 1, col); // Move up
            FindAllPaths(row, col - 1); // Move left

            labyrith[row, col] = '_';
        }

        public static void SavePath()
        {
            for (int row = 0; row < labyrith.GetLength(0); row++)
            {
                for (int col = 0; col < labyrith.GetLength(1); col++)
                {
                    sb.Append(labyrith[row, col]);
                }
                sb.AppendLine();
            }
            sb.AppendLine(new string('*', 10));
        }
    }
}
