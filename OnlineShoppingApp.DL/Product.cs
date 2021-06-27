using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingApp.DL
{
    public class Product
    {
        public string laptopBrand;
        private string price;
        private DateTime date;

        public Product(string laptopBrand, string price, DateTime date)
        {
            this.laptopBrand = laptopBrand;
            this.price = price;
            this.date = date;


        }


        public string ShirtBrand
        {
            get { return laptopBrand; }
            set { laptopBrand = value; }
        }


        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


    }
}
  