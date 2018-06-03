using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a number and a list of numbers as a parameter
            //  Returns the indeces of the numbers in the list where the first number is part of
            //  Returns an empty list if the number is not part any of the numbers in the list

            //  Example:
            Console.WriteLine(SubInt(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            Console.WriteLine(SubInt(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'

            Console.ReadLine();
        }

        public static string SubInt(int inputNum, int[] inputList)
        {
            string temp = string.Empty;
            string strInputNum = Convert.ToString(inputNum);
            string[] strInputList = new string[inputList.Length];

            for (int i = 0; i < inputList.Length; i++)
            {
                strInputList[i] = Convert.ToString(inputList[i]);
            }

            for (int i = 0; i < inputList.Length; i++)
            {
                if (strInputList[i].Contains(strInputNum))
                {
                    temp += Convert.ToString(i) + ", ";
                }
            }

            return temp;
        }
    }
}
