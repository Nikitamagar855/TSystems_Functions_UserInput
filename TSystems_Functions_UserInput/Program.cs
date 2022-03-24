using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_Functions_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            ArithmaticOp objArithmaticOp = new ArithmaticOp();
            objArithmaticOp.add(a,b);
            objArithmaticOp.sub(a, b);
            objArithmaticOp.mul(a, b);
            objArithmaticOp.div(a, b);
            Console.ReadLine();



        }
    }


    public class ArithmaticOp
    {
        public void  add(int a,int b)
        {
            Console.WriteLine($"Addition is { a + b}" );
            
        }
        public void sub(int a, int b)
        {
            Console.WriteLine($"Substraction is { a - b}" );

        }
        public void mul(int a, int b)
        {
            Console.WriteLine($"multiplication  is { a * b}");

        }
        public void div(int a, int b)
        {
            Console.WriteLine($"Division  is { a/ b}");

        }
    }
}
