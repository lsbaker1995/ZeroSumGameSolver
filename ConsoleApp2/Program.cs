using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            EnterMatrix(); ReduceMatrix();
        }


        static void EnterMatrix()
        {
            int n, m;

            Console.Write("Enter the dimension of the row: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the dimension of the column: ");
            n = Convert.ToInt32(Console.ReadLine());


            var matrix = new List<List<int>>();

            for (int i = 0; i < m; i++)
            {
                var newColumn = new List<int>();

                for (int j = 0; j < n; j++)
                {
                    newColumn.Add(Convert.ToInt32(Console.ReadLine()));
                }

                matrix.Add(newColumn);
            }

           foreach(var row in matrix)
                for(int i = 0; i < n; i++)
                {
                    if(i == n - 1)
                        Console.WriteLine(row.ElementAt(i));
                    else
                        Console.Write(row.ElementAt(i));
                }

           bool matrixAlteredFlag = true;
           while(matrixAlteredFlag == true)
            {
                RemoveRows(matrix, n, m);
                RemoveColumn(matrix, n, m);
            }

            foreach (var row in matrix)
                for (int i = 0; i < n; i++)
                {
                    if (i == n - 1)
                        Console.WriteLine(row.ElementAt(i));
                    else
                        Console.Write(row.ElementAt(i));
                }

        }

        static void ReduceMatrix()
        {

        }

        private static void RemoveRows(List<List<int>> matrix, int rows, int columns)
        {
            //insert good code here
            //This is where you put the logic to remove a row
        }

        private static void RemoveColumn(List<List<int>>matrix , int rows, int columns)
        {
            // insert more good code here
            //This is where you implement logic for removing a column
        }

    }
}
