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
                var rowAlteredFlag = RemoveRows(matrix);
                if (rowAlteredFlag == 1)
                {
                    matrix.RemoveAt(1);
                }
                else if (rowAlteredFlag == 2)
                {
                    matrix.RemoveAt(0);
                }
                else if(rowAlteredFlag == 3)
                {
                    break;
                }
                var columnAlteredFlag = RemoveColumn(matrix);
                if (columnAlteredFlag == 1)
                {
                    foreach (var row in matrix)
                        row.RemoveAt(0);
                }
                else if (columnAlteredFlag == 2)
                {
                    foreach (var row in matrix)
                        row.RemoveAt(1);
                }
                else if(columnAlteredFlag == 3)
                {
                    break;
                }
            }

            foreach (var row in matrix)
                for (var i = 0; i < matrix.Count; i++)
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

        private static int RemoveRows(List<List<int>> matrix)
        {
            var columns = matrix.ElementAt(0).Count();
            var rowElementsAreDominant = new List<string>();
            if (matrix.Count() == 1)
            {
                return 3;
            }
            for (int i = 0; i <= columns - 1; i++)
            {
                if (matrix.ElementAt(0).ElementAt(i) > matrix.ElementAt(1).ElementAt(i))
                {
                    rowElementsAreDominant.Add("Yes");
                }
                else if(matrix.ElementAt(0).ElementAt(i) < matrix.ElementAt(1).ElementAt(i))
                {
                    rowElementsAreDominant.Add("No");
                }
                else if (matrix.ElementAt(0).ElementAt(i) == matrix.ElementAt(1).ElementAt(i))
                {
                    rowElementsAreDominant.Add("Equal");
                }
            }

            var dominantColumnsNumber = rowElementsAreDominant.Where(r => r.Equals("Yes"));
            var nonDominantColumnsNumber = rowElementsAreDominant.Where(r => r.Equals("No"));
            var equalColumns = rowElementsAreDominant.Where(r => r.Equals("Equal"));
            var numberOfEqualColumns = equalColumns.Count();

            if (dominantColumnsNumber.Count() + numberOfEqualColumns == columns)
            {
                return 1;
            }
            else if (nonDominantColumnsNumber.Count() + numberOfEqualColumns == columns)
            {
                return 2;
            }
            else
            {
                return 3;
            }

        }

        private static int RemoveColumn(List<List<int>>matrix)
        {
            // insert more good code here
            //This is where you implement logic for removing a column
            var rows = matrix.Count();
            var columnElementsAreDominant = new List<string>();
            if (matrix.ElementAt(0).Count() == 1)
            {
                return 3;
            }
            for (int i = 0; i <= rows - 1; i++)
            {
                if (matrix.ElementAt(i).ElementAt(0) >= matrix.ElementAt(i).ElementAt(1))
                {
                    columnElementsAreDominant.Add("Yes");
                }
                else if(matrix.ElementAt(i).ElementAt(0) <= matrix.ElementAt(i).ElementAt(1))
                {
                    columnElementsAreDominant.Add("No");
                }
                else if (matrix.ElementAt(0).ElementAt(i) == matrix.ElementAt(1).ElementAt(i))
                {
                    columnElementsAreDominant.Add("Equal");
                }
            }

            var dominantRowItemsNumber = columnElementsAreDominant.Where(r => r.Equals("Yes"));
            var nonDominantRowItemsNumber = columnElementsAreDominant.Where(r => r.Equals("No"));
            var equalRows = columnElementsAreDominant.Where(r => r.Equals("Equal"));
            var numberOfEqualRows = equalRows.Count();
            
            if (dominantRowItemsNumber.Count() + numberOfEqualRows == rows)
            {
                return 1;
            }
            else if (nonDominantRowItemsNumber.Count() + numberOfEqualRows == rows)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

    }
}
