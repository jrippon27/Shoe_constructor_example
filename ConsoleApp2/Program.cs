using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public struct shoes
        {
            public string name;
            public string type;
            public string color;
            public int productCode;

            public shoes(string name, string type, string color, int productCode)
            {
                this.name = name;
                this.type = type;
                this.color = color;
                this.productCode= productCode;
            }
        }
        static void Main(string[] args)
        {
            shoes myShoes = new shoes("DC Shoes", "Skate Shoes", "Black", 116546483);

            Console.WriteLine(myShoes.name);
            Console.WriteLine(myShoes.type);
            Console.WriteLine(myShoes.color);
            Console.WriteLine(myShoes.productCode);

            Console.ReadKey();
        }
    }
}
