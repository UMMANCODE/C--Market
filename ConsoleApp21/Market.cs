using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21 {
    internal class Market : IStore {
        private Product[] _products = new Product[0];
        private uint _producLimit;
        private double _totalİncome = 0;

        public Product[] Products => _products;
        public uint ProductLimit { get => _producLimit; set => _producLimit = value; }
        public double Totalİncome => _totalİncome;

        public Market(uint productLimit) {
            _producLimit = productLimit;
        }

        public void AddProduct(Product product) {
            if (product == null) return;
            if (_products.Length >= _producLimit) return;
            if (HasProduct(product)) return;
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }

        public void SellProduct(string name) {
            if (string.IsNullOrWhiteSpace(name.Trim())) return;
            if (_products.Length == 0) return;
            Product? product = null;
            foreach (var item in _products) {
                if (item.Name == name) {
                    product = item;
                    break;
                }
            }
            if (product == null || product.Count == 0) return;
            product.Count--;
            _totalİncome += product.Price;
        }

        private bool HasProduct(Product product) {
            if (product == null) return false;
            foreach (var item in _products) {
                if (item.Name == product.Name) return true;
            }
            return false;
        }
    }
}
