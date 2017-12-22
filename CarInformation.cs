using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership
{
    class CarInformation
    {
        string make;
        string model;
        int year;
        double price;
        double discount;
        
        public CarInformation(string _make, string _model, int _year)
        {
            make = _make;
            model = _model;
            year = _year;
        }

        public void setPrice(double p)
        {
            price = p;
        }

        public double getPrice()
        {
            return price;
        }

        public void setDiscount(double _double)
        {
            _double = _double / 100;
            discount = _double;
        }

        public double getDiscount()
        {
            double discountedPrice = price * discount;
            discountedPrice = price - discountedPrice;
            return discountedPrice;
        }
    }
}
