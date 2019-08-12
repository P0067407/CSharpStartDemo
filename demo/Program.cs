using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = "444";
            Console.WriteLine(size);
            Console.WriteLine($"{444}");
            Console.WriteLine("abcdefgh".Substring(2));
            Console.WriteLine("abcdefgh".Substring(2, 3));
            Console.WriteLine("abcdefghabcd".Replace("abcd","xxxx"));
            int random = new Random().Next(1000);
            Console.WriteLine(random);
            //729600626
        }
         
    }
}
