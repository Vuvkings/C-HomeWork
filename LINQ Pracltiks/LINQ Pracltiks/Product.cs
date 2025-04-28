using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Pracltiks
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public Product(string name, string category)
        {
            Name = name;
            Category = category;
        }
    }
}
