
namespace ConsoleApp1
{
    using System;

    using TestNugetPackage;

    static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Class1.TestString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
