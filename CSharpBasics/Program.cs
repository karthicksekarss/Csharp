using System;
using CSharpBasics.Extension;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            string EmpCode = "120780";
            NeedsExtension obj = new NeedsExtension();
            Console.WriteLine(EmpCode.GetEmployeeCodeWithCompanyName("Google"));
            Console.WriteLine(obj.GetService());
            Console.WriteLine("9677".ToString());
            Console.Read();
        }
    }

    public sealed class NeedsExtension
    {
    }
   
}
