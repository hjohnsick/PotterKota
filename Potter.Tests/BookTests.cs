using PotterKota;
using System;
using System.Reflection;
using Xunit;

namespace Potter.Tests
{
    public class BookTests
    {
        private readonly Book book;

        public BookTests()
        {
            book = new Book();

        }

        [Fact]
        public void NoBooksPurchased()
        {
            
            var expected = 0;

            var actual = book.GetTotalCost(0, 0);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OneBookPurchased()
        {
 
            var expected = 8;

            var actual = book.GetTotalCost(1, 0);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TwoSameBooksPurchased()
        {

            var expected = 16;

            var actual = book.GetTotalCost(2, 0);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TwoDifferentBooksPurchased()
        {          
            var expected = 15.2;
            
            var actual = book.GetTotalCost(0, 2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TwoSameBooksOneDiffPurchased()
        {
            var expected = 23.2;

            var actual = book.GetTotalCost(2, 1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ThreeDifferentBooks()
        {
            var expected = 22.2;

            var actual = book.GetTotalCost(0, 3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ThreeDifferentBooksOneSame()
        {
            var expected = 30.2;

            var actual = book.GetTotalCost(1, 3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ThreeDifferentBooksTwoSame()
        {
            var expected = 38.2;

            var actual = book.GetTotalCost(2, 3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FourDifferentBooks()
        {
            var expected = 25.6;

            var actual = book.GetTotalCost(0, 4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FourDifferentBooksThreeSame()
        {
            var expected = 49.6;

            var actual = book.GetTotalCost(3, 4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FiveDifferentBooks()
        {
            var expected = 30;

            var actual = book.GetTotalCost(0, 5);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultipleBookSitutation()
        {
            var expected = 51.2;

            var actual = book.GetTotalCost(3, 5);

            Assert.Equal(expected, actual);
        }
    }
}
