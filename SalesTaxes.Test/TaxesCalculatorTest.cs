//using Sales_Taxes.Logic.Models;
//using Sales_Taxes.Logic.StoreComponents.Components;
//using System.Collections.Generic;
//using Xunit;

//namespace SalesTaxes.Test
//{
//    public class TaxesCalculatorTest
//    {
//        private IEnumerable<Item> items;
//        private IEnumerable<Item> items2;
//        private IEnumerable<Item> items3;

//        public TaxesCalculatorTest()
//        {
//            items = new List<Item>
//            {
//                new Item {Name = "Book", Price = 12.49m, IsTaxable = false, IsImported = false},
//                new Item {Name = "Book", Price = 12.49m, IsTaxable = false, IsImported = false},
//                new Item {Name = "Music CD", Price = 14.99m, IsTaxable = true, IsImported = false},
//                new Item {Name = "Chocolate Bar", Price = 0.85m, IsTaxable = false, IsImported = false}
//            };

//            items2 = new List<Item>
//            {
//                new Item {Name = "Imported Chocolate", Price = 10.0m, IsTaxable = false, IsImported = true},
//                new Item {Name = "Imported Perfume", Price = 47.50m, IsTaxable = true, IsImported = true}
//            };

//            items3 = new List<Item>
//            {
//                new Item {Name = "Book", Price = 27.99m, IsTaxable = true, IsImported = true},
//                new Item {Name = "Book", Price = 18.99m, IsTaxable = true, IsImported = false},
//                new Item {Name = "Music CD", Price = 9.75m, IsTaxable = false, IsImported = false},
//                new Item {Name = "Chocolate Bar", Price = 11.25m, IsTaxable = false, IsImported = true},
//                new Item {Name = "Chocolate Bar", Price = 11.25m, IsTaxable = false, IsImported = true}
//            };
//        }

//        [Fact]
//        public void ShouldCalculateTaxes()
//        {
//            //Arrange
//            decimal expected = 1.50m;

//            //Act
//            var calculator = new TaxesCalculator(10.0m, 5.0m);
//            var actual = calculator.CalculateTaxes(items);

//            //Assert
//            Assert.Equal(expected, actual);
//        }

//        [Fact]
//        public void ShouldCalculateTaxes2()
//        {
//            //Arrange
//            decimal expected = 7.65m;

//            //Act
//            var calculator = new TaxesCalculator(10, 5);
//            var actual = calculator.CalculateTaxes(items2);

//            //Assert
//            Assert.Equal(expected, actual);
//        }

//        [Fact]
//        public void ShouldCalculateTaxes3()
//        {
//            //Arrange
//            decimal expected = 7.30m;

//            //Act
//            var calculator = new TaxesCalculator(10, 5);
//            var actual = calculator.CalculateTaxes(items3);

//            //Assert
//            Assert.Equal(expected, actual);
//        }

//        [Fact]
//        public void ShouldRoundWell()
//        {
//            //arrange
//            //decimal expected = ;
//        }
//    }
//}
