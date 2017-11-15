using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less13_01
{
    public class Pen
    {
        public const int Size = 668;
        public int Weight;
        private int _x;

        private string _manufacturer;

        public int MyProperty { get; set; }

        public int SizePen { get; set; }

        private double _price;

        public double Price => _price;

        public string Manufacturer
        {
            get { return _manufacturer;  }
            set { _manufacturer = value; }
        }

        //public Pen()
        //{
        //    int x = 99;
        //    this._x = x;
        //}

        public Pen(string manufacturer)
        {
            _manufacturer = manufacturer;
        }

    }
}
