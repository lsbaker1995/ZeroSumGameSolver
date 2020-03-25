using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            Console.Write("Enter the dimension of the row: ");
            var m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the dimension of the column: ");
            var n = Convert.ToInt32(Console.ReadLine());


            var matrix = new List<List<int>>();

            for (var i = 0; i < m; i++)
            {
                var newColumn = new List<int>();

                for (var j = 0; j < n; j++)
                {
                    newColumn.Add(Convert.ToInt32(Console.ReadLine()));
                }

                matrix.Add(newColumn);
            }

            foreach(var row in matrix)
                for(var i = 0; i < n; i++)
                {
                    if(i == n - 1)
                        Console.WriteLine(row.ElementAt(i));
                    else
                        Console.Write(row.ElementAt(i));
                }
            


            while(true)
            {
                var matrixAlteredFlag = RemoveRows(matrix, n, m);
                if (matrixAlteredFlag != true)
                    break;
                matrixAlteredFlag = RemoveColumn(matrix, n, m);
                if (matrixAlteredFlag != true)
                    break;
            }

            foreach (var row in matrix)
                for (var i = 0; i < n; i++)
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

        private static bool RemoveRows(List<List<int>> matrix, int rows, int columns)
        {
            var rowElementAreDominant = new List<string>();
            for (int i = 0; i < columns; i++)
            {
                if (matrix.ElementAt(0).ElementAt(i) >= matrix.ElementAt(1).ElementAt(i))
                {
                    rowElementAreDominant.Add("Yes");
                }
                else if(matrix.ElementAt(0).ElementAt(i) <= matrix.ElementAt(1).ElementAt(i))
                {
                    rowElementAreDominant.Add("No");
                }
            }

            var dominantColumnsNumber = rowElementAreDominant.Where(r => r.Equals("Yes"));
            var nonDominateColumnsNumber = rowElementAreDominant.Where(r => r.Equals("No"));

            if (dominantColumnsNumber.Count() == columns)
            {
                matrix.RemoveAt(1);
                return true;
            }
            else if (nonDominateColumnsNumber.Count() == columns)
            {
                matrix.RemoveAt(0);
                return true;
            }
            else
            {
                return false;
            }

        }

        private static bool RemoveColumn(List<List<int>>matrix , int rows, int columns)
        {
            // insert more good code here
            //This is where you implement logic for removing a column
            return true;
        }

    }
}
