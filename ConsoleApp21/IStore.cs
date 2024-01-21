using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21 {
    internal interface IStore {

        public void AddProduct(Product product);
        public void SellProduct(string name);
    }
}
