using System;

namespace GithubCoreosole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Github Added");
            Add(12, 13);
        }

        static void Add(int num1,int num2)
        {
            Console.WriteLine("Addition Is:{0}", num1 + num2);
        }
    }
}
