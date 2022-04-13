using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class MyBigInteger
    {
        int Positive = 1;

        public MyBigInteger(string num, int positive)
        {
            for (int i = 0; i < num.Length; i++)
            {
                string s = (num[i].ToString());
                numbers.Add(byte.Parse(s));
            }

            Positive = positive;
        }

        List<byte> numbers = new List<byte>();


        public void Print()
        {
            foreach (int i in numbers)
                Console.Write(i);
        }

        public static bool operator >(MyBigInteger a, MyBigInteger b)
        {
           return (a.CompareTo(b)) == 1;
        }

        public static bool operator <(MyBigInteger a, MyBigInteger b)
        {
            return (b.CompareTo(a)) == 1;
        }


        private int CompareTo(MyBigInteger other)
        {
            if (Positive != other.Positive) return Positive.CompareTo(other.Positive);
            if (numbers.Count != other.numbers.Count) return numbers.Count.CompareTo(other.numbers.Count);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > other.numbers[i])
                    return 1;

                if (numbers[i] < other.numbers[i])
                    return -1;
            }
            return 0;

        }

   
  
    }
}
