using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21 {
    internal class Product {
        private string _name;
        private double _price;
        private uint _count;
        public string Name {
            get => _name;
            set {
                if (string.IsNullOrWhiteSpace(value.Trim())) return;
                _name = value;
            }
        }
        public double Price {
            get => _price;
            set {
                if (value < 0) return;
                _price = value;
            }
        }
        public uint Count {
            get => _count;
            set {
                if (value < 0) return;
                _count = value;
            }
        }

        public Product(string name, double price, uint count) {
            _name = name;
            _price = price;
            _count = count;
        }
    }
}
