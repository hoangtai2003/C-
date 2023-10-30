using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class ProductEnumerable
    {
        string[] product = { "Giay", "Dep", "Quan" };
        public IEnumerable<string> GetProduct()
        {
            for (int i = 0; i < product.Length; i++)
            {
                yield return product[i];
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                ProductEnumerable productEnumerable = new ProductEnumerable();
                foreach (string item in productEnumerable.GetProduct())
                {
                     Console.WriteLine(item);
                }
            }
        } 
    }
}
