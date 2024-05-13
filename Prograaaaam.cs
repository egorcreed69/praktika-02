using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ффф
{
    internal class Program
    {
        public static class MatrixExtensions
        {
            public class Matrix
            {
                private int[][] matrix;

                public Matrix(int[][] matrix)
                {
                    this.matrix = matrix;
                }

                public void Transpose()
                {
                    matrix = Enumerable.Range(0, matrix[0].Length)
                        .Select(i => matrix.Select(row => row[i]).ToArray())
                        .ToArray();
                }

                public void RotateClockwise()
                {
                    matrix = matrix.Reverse().Select(row => row.ToArray()).ToArray();
                }

                public void SortRows()
                {
                    matrix = matrix.Select(row => row.OrderBy(x => x).ToArray()).ToArray();
                }

                public void ReverseColumnsOrder()
                {
                    matrix = matrix.Select(row => row.Reverse().ToArray()).ToArray();
                }

                public void Print()
                {
                    foreach (var row in matrix)
                    {
                        foreach (var element in row)
                        {
                            Console.Write(element + "\t");
                        }
                        Console.WriteLine();
                    }
                }

            }
            static void Main(string[] args)
            {
                var matrix = new Matrix(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } });
                matrix.Transpose();
                matrix.RotateClockwise();
                matrix.SortRows();
                matrix.ReverseColumnsOrder();
                matrix.Print();
                Console.WriteLine("Последовательность действий: 1 Создание объекта матрицы.", "2 Вывод матрицы на консоль." +
                    "3 Транспонирование матрицы.", "4 Вывод транспонированной матрицы на консоль." +
                    "5 Поворот матрицы по часовой стрелке." ,"6 Вывод повернутой матрицы на консоль." +
                    "7 Сортировка строк матрицы." ,"8 Вывод отсортированной матрицы на консоль." +
                    "9 Изменение порядка столбцов на обратный." ,"10 Вывод матрицы с обратным порядком столбцов на консоль.");
                Console.ReadKey();
            }
        }
    }
}
