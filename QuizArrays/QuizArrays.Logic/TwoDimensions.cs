using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizArrays.Logic
{
    public class TwoDimensions
    {
        #region Attributes
        private int[,] _array;
        #endregion

        #region Constructors
        public TwoDimensions(int m, int n)
        {
            M = m;
            N = n;
            _array = new int[m, n]; 
        }
        #endregion

        #region Properties
        public int M { get; }

        public int N { get; }
        #endregion

        #region Methods
        public void Fill()
        {
            var random = new Random();

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    _array[i, j] = random.Next(1, 100);
                }
            }
        }

        public OneDimension ToOneDimension()
        {
            int size = N * M;
            var array = new OneDimension(size);

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array.Add(_array[i, j]);
                }
            }

            return array;
        }

        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += $"{_array[i, j]} \t";
                }
                output += "\n";
            }
            return output;
        }
        #endregion
    }
}
