using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp10
{
    internal class Program

    {
        static void Main(string[] args)
        {
            
            BigInteger sdf = new BigInteger(123123123);
            MyBigInteger myBigInteger = new MyBigInteger("123123123123123123123123123123123123123123123123123123123123123123123123123123123123123123123123123123123123123123123", 1);
            MyBigInteger myBigInteger2 = new MyBigInteger("121231231231231231231231231231231231231231231231231231231231231231231231233", 1);


            Console.WriteLine(myBigInteger > myBigInteger2); 
            //myBigInteger.Print();

            Console.ReadKey();
        }
    }
}
