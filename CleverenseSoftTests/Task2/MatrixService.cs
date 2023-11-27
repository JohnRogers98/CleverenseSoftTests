
namespace CleverenseSoftTests.Task2
{
    internal class MatrixService : IMatrixService
    {
        public T[] GetMatrixCounterWiseArray<T>(T[,] matrix)
        {
            List<T> listOElements = new List<T>();

            Int32 i, k = 0, l = 0;
            Int32 m = matrix.GetLength(0);
            Int32 n = matrix.GetLength(1);

            Int32 count = 0;

            Int32 total = matrix.Length;

            while (k < m && l < n)
            {
                if (count == total)
                    break;

                for (i = k; i < m; ++i)
                {
                    listOElements.Add(matrix[i, l]);
                    count++;
                }
                l++;

                if (count == total)
                    break;

                for (i = l; i < n; ++i)
                {
                    listOElements.Add(matrix[m - 1, i]);
                    count++;
                }
                m--;

                if (count == total)
                    break;

                if (k < m)
                {
                    for (i = m - 1; i >= k; --i)
                    {
                        listOElements.Add(matrix[i, n - 1]);
                        count++;
                    }
                    n--;
                }

                if (count == total)
                    break;
            }

            return listOElements.ToArray();
        }

    }
}
