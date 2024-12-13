using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawdy_Exam2
{
    internal class theProducts
    {
        // Kylie Drawdy

        // Declare properties / variables
        private string _name, _description;
        private double _price;
        private int _quantity;

        // constructor that sets default values for properties
        public theProducts()
        {
            // assign appropriate default values to properties
            _name = "";
            _description = "";
            _price = 0;
            _quantity = 5;
        }

        // getter and setter for name
        public string Name
        {
            // get and return variable
            get
            {
                return _name;
            }
            // set equal to value given to method
            set
            {
                _name = value;
            }
        }

        // getter and setter for price
        public double Price
        {
            // get and return variable
            get
            {
                return _price;
            }
            // set equal to value given to method
            set
            {
                _price = value;
            }
        }

        // getter and setter for description
        public string Description
        {
            // get and return variable
            get
            {
                return _description;
            }
            // set equal to value given to method
            set
            {
                _description = value;
            }
        }

        // getter and setter for quantity
        public int Quantity
        {
            // get and return variable
            get
            {
                return _quantity;
            }
            // set equal to value given to method
            set
            {
                _quantity = value;
            }
        }

    }
}
