using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter defaultnumber = new Counter();
            defaultnumber.Add();

            Console.WriteLine(defaultnumber.Get());
            Console.ReadLine();
        }
    }

    class Counter
    {
        public int defaultNumber = 0;

        public void Add()
        {
            defaultNumber++;
        }

        public string Get()
        {
            string result = defaultNumber.ToString();
            return result;
        }

        public void Reset()
        {
            defaultNumber = 0;
        }
    }
}
//Create Counter class
//which has an integer property
//when creating it should have a default value 0 or we can specify it when creating
//we can Add(number) to this counter another whole number
//or we can Add() without parameters just increasing the counter's value by one
//and we can Get() the current value as string
//also we can Reset() the value to the initial value
