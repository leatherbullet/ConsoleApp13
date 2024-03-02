using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            char userSign;
            string signs = "";
            int numberOfSign;

            Console.WriteLine("введите имя");
            name = Console.ReadLine();
            Console.WriteLine("введите символ");
            userSign = Console.ReadKey().KeyChar;

            string signNameSing = userSign + name + userSign;
            numberOfSign = signNameSing.Length;

            for (int i = 0; i < numberOfSign; i++)
            {
                signs += userSign;
            }
            Console.Clear();
            Console.WriteLine(signs);
            Console.WriteLine(signNameSing);
            Console.WriteLine(signs);
        }
    }
}
