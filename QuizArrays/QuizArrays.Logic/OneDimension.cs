using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizArrays.Logic
{
    public class OneDimension
    {
        #region Attributes
        private int[] _array;
        private int _top;
        #endregion

        #region Constructors
        public OneDimension(int n)
        {
            N = n;
            _array = new int[n];
            _top = 0;
        }
        #endregion

        #region Properties
        public bool IsEmpty => _top == 0;

        public bool IsFull => _top == N;

        public int N { get; }
        #endregion

        #region Methods
        public void Add(int number)
        {
            if (IsFull)
            {
                throw new Exception("The array is full.");
            }

            _array[_top] = number;
            _top++;
        }

        public override string ToString()
        {
            if (IsEmpty)
            {
                return "Empty array.";
            }

            string output = string.Empty;
            for (int i = 0; i < _top; i++)
            {
                output += $"{_array[i]}\t";
            }

            return output;
        }
        #endregion
    }
}
