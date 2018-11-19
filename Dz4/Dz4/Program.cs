using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4
{
    class Program
    {
        static void Main(string[] args)
        {

            IndexArr indexArr = new IndexArr(2);
            indexArr[0] = 5;
            Console.WriteLine(indexArr[0]);
            Console.ReadLine();
        }
    }
}
