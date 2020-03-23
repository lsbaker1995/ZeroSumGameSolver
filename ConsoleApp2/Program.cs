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

            if((matrix.ElementAt(0).ElementAt(0) > matrix.ElementAt(1).ElementAt(0)) && (matrix.ElementAt(0).ElementAt(1) > matrix.ElementAt(1).ElementAt(0)))
            {
                matrix.RemoveAt(1);
            } else
            {
                matrix.RemoveAt(0);
            }

            var result = matrix.ElementAt(0).Min();

            Console.WriteLine(result);

        }

        static void ReduceMatrix()
        {

        }

    }
}
