using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     public partial class Product
    {
        private static int id = 0;
        private string name;
        private int cost;
        private static DateTime creationDate;
        private string category;
        private DateTime expirationDate;
        private static int count = 0;

        public Product(string name, int cost, DateTime creationDate, string category, DateTime expirationDate)
        {
            this.name = name;
            this.cost = cost;
           
            this.category = category;
            this.expirationDate = expirationDate;
            id++;
            count++;
        }

        static Product(){
            creationDate =  DateTime.Now;

        }

        public Product(int id, int cost, int count, string name, DateTime creationDate)
        {
            Id = id;
            Cost = cost;
            Count = count;
            Name = name;
            CreationDate = creationDate;
        }

        public Product()
        {
            id++;
            count++;
            cost = 0;
            creationDate = new DateTime(0, 0, 0);
            expirationDate = new DateTime(0, 0, 0);
            category = " ";
            name = " ";
        }

        public int Id { get; set; }
        public int Cost { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        
    }
}
