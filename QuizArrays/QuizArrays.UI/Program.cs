using QuizArrays.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizArrays.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAY QUIZ");
            var twoDimensions = new TwoDimensions(5, 3);
            twoDimensions.Fill();
            Console.WriteLine("Two dimensions array =>");
            Console.WriteLine(twoDimensions);
            var oneDimension = twoDimensions.ToOneDimension();
            Console.WriteLine("One dimension array =>");
            Console.WriteLine(oneDimension);

        }
    }
}
