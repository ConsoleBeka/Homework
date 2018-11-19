using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIrstLibrary;
namespace Person_Library
{
    class Program
    {
        static void Main(string[] args)
        {
      
        }

        static void FirstTask() {
            FIrstLibrary.Person person = new FIrstLibrary.Person("He", "She", 18);

            FIrstLibrary.Class1 firstClass = new Class1();
            string str = firstClass.StaticMethod(person);
            Console.WriteLine(str);
        }

        static void SecondTask() {
            Book Lotr = new Book();
            Console.WriteLine($"Название: {Lotr.GetName}");
            Console.WriteLine($"Кол-во страниц: {Lotr.GetcountOfPages}");
            Console.WriteLine($"Имя автора: {Lotr.GetauthorName}");
        }
    }
}
