using System;
using System.Runtime.InteropServices;


namespace ConsoleApp_NetCore
{
    public class Program
    {
        // Insert correct filePath
        [DllImport(@"C:\Users\Ajay\Documents\Visual Studio 2017\Projects\CPPDLL\Debug\CPPDLL.dll", EntryPoint =
         "math_add", CallingConvention = CallingConvention.StdCall)]
        public static extern int Add(int a, int b);
        public static void Main(string[] args)
        {
            int result = Add(1, 2);
            Console.WriteLine("result is {0}", result);
            //Halts the program
            Console.ReadKey();
        }

    }
}
