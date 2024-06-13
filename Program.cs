using System.ComponentModel.DataAnnotations;

namespace Assignment6._4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 1, 2, 3, }, { 4, 5, 6, }, { 7, 8, 9 } };
            
            Print(matrix);

            rotate(matrix);

            Print(matrix);



        }

        public static void rotate(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;//take normal index and move back one more for each layer


                for (int x = first; x < last; x++)
                {
                    int offset = x - first;//decrement

                    int top = matrix[first, x];//saves top row

                    matrix[first, x] = matrix[last - offset, first];//left to top

                    matrix[last - offset, first] = matrix[last, last - offset];//bottom to left

                    matrix[last, last - offset] = matrix[x, last];//right to bottom

                    matrix[x, last] = top;//top
                }
            }



        }
        static void Print(int[,] array) //prints array
        {
            int num = 3; 
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine();
            }
             
        }
    }
}
