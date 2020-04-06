using System;


namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {

            // determin the renk of the matrix, initialize it with string values
            int rank = 3;
            string[][] matrix = new string[rank][];
            
            for (int row = 0; row < matrix.Length; row++)
			{
                matrix[row] = new string[rank];
                
                
                for (int col = 0; col < matrix[row].Length; col++)
			    {
                    if (row>col)
                    {
                        matrix[row][col] = "down";
                    }
                    else if (row<col)
                    {
                        matrix[row][col] = "up";
                    }
			    }
                
                matrix[row][rank - row - 1] = "sub";
                matrix[row][row] = "main";
            }

            //print the matrix
            foreach (string[] row in matrix)
            {
                foreach (string col in row)
                {
                    Console.Write(col + ", ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
