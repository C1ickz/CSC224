using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfObjects
{
    class Vehicle
    {

        private string make;
        private string model;
        private int year;
        private decimal miles;
        private decimal price;
        public Vehicle(string make, string model, int year, decimal miles, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Miles = miles;
            this.Price = price;

        }

        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                if (value < 1900)
                {
                    System.Windows.Forms.MessageBox.Show("Year cannot be before 1900 -- using 1900 instead", "Year Error");
                    year = 1900;
                }
                else
                {
                    year = value;
                }
            }
        }

        public decimal Miles
        {
            get
            {
                return miles;
            }

            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Miles can not be less than 0 --setting miles to 0", "Mile Error");
                    miles = 0;
                }
                else
                {
                    miles = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return Price;
            }
            set
            {
                if(value <= 0)
                {
                    MessageBox.Show("Price cannot be less than $0.00", "Price Error");
                    price = 0;
                }
                else
                {
                price = value;
                }
            }
        }

        public string GetDisplayText()
        {
            return "a " + this.year + " " + this.make + " " +
                this.model + " with " + this.miles + 
                " miles, selling for " + this.price.ToString("c");
        }



    }
}
