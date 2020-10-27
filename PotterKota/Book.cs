using System;
using System.Collections.Generic;
using System.Text;

namespace PotterKota
{
    public class Book
    {
        private readonly double discountTwoBooks = .8;
        private readonly double discountThreeBooks = 1.8;
        private readonly double discountFourBooks = 6.4;
        private readonly double discountFiveBooks = 10;

        public double GetTotalCost(int numberOfSameBooks, int numberOfDifferentBooks)
        {
            double regularPrice = 8;
            double salePrice = 0;
            double totalPrice = 0;

            if (numberOfSameBooks >= 0)
            {
                totalPrice = regularPrice * numberOfSameBooks;
                
            }
            if (numberOfDifferentBooks == 5)
            {
                salePrice = (numberOfDifferentBooks * regularPrice) - discountFiveBooks;
                totalPrice = salePrice + totalPrice;
            }
            else if (numberOfDifferentBooks == 4)
            {
                salePrice = (numberOfDifferentBooks * regularPrice) - discountFourBooks;
                totalPrice = salePrice + totalPrice;
            }
            else if (numberOfDifferentBooks == 3)
            {
                salePrice = (numberOfDifferentBooks * regularPrice) - discountThreeBooks;
                totalPrice = salePrice + totalPrice;
            }
            else if (numberOfDifferentBooks >= 0)
            {
                salePrice = (numberOfDifferentBooks * regularPrice) - discountTwoBooks;
                totalPrice = salePrice + totalPrice;
            }

            return totalPrice;
        }

        
    }
}
