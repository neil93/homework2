using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
using System.Collections.Generic;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private const string HarryPoter1 = "Harry Poter.No1";
        private const string HarryPoter2 = "Harry Poter.No2";
        private const string HarryPoter3 = "Harry Poter.No3";
        private const string HarryPoter4 = "Harry Poter.No4";
        private const string HarryPoter5 = "Harry Poter.No5";


        [TestMethod]
        public void 第一集買了一本_其他都沒買_價格應為100元()
        {
            //arrage
            var target = new ShoppingCart();
            var details = new List<CartDetail>()
            {
                new CartDetail(){
                ProductName = HarryPoter1,
                Amount = 1,
                Price = 100
                },
            };
          

            //act
            var expected = 100;
            var actual = target.CalcuatePrice(details);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 第一集買了一本_第二集也買了一本_價格應為190()
        {
            //arrage
            var target = new ShoppingCart();

            var details = new List<CartDetail>()
            {
                new CartDetail(){
                ProductName = HarryPoter1,
                Amount = 1,
                Price = 100
                },
                new CartDetail(){
                ProductName = HarryPoter2,
                Amount = 1,
                Price = 100
                },
            };

            //act
            var expected = 190;
            var actual = target.CalcuatePrice(details);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三集各買了一本_價格應為270()
        {
            //arrage
            var target = new ShoppingCart();

            var details = new List<CartDetail>()
            {
                new CartDetail(){
                ProductName = HarryPoter1,
                Amount = 1,
                Price = 100
                },
                new CartDetail(){
                ProductName = HarryPoter2,
                Amount = 1,
                Price = 100
                },
                new CartDetail(){
                ProductName = HarryPoter3,
                Amount = 1,
                Price = 100
                },
            };

            //act
            var expected = 270;
            var actual = target.CalcuatePrice(details);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三四集各買了一本_價格應為320()
        {
            //arrage
            var target = new ShoppingCart();

            var details = new List<CartDetail>()
            {
                new CartDetail(){
                ProductName = HarryPoter1,
                Amount = 1,
                Price = 100
                },
                new CartDetail(){
                ProductName = HarryPoter2,
                Amount = 1,
                Price = 100
                },
                new CartDetail(){
                ProductName = HarryPoter3,
                Amount = 1,
                Price = 100
                },
                new CartDetail(){
                ProductName = HarryPoter4,
                Amount = 1,
                Price = 100
                },
            };

            //act
            var expected = 320;
            var actual = target.CalcuatePrice(details);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三四五集各買了一本_價格應為375()
        {
            //arrage
            var target = new ShoppingCart();

            var details = new List<CartDetail>()
            {
                new CartDetail(){
                ProductName = HarryPoter1,
                Amount = 1,
                Price = 100
                },
                new CartDetail(){
                ProductName = HarryPoter2,
                Amount = 1,
                Price = 100
                },
                new CartDetail(){
                ProductName = HarryPoter3,
                Amount = 1,
                Price = 100
                },
                new CartDetail(){
                ProductName = HarryPoter4,
                Amount = 1,
                Price = 100
                },
                new CartDetail(){
                ProductName = HarryPoter5,
                Amount = 1,
                Price = 100
                },
            };

            //act
            var expected = 375;
            var actual = target.CalcuatePrice(details);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二集各買了一本_第三集買了兩本_價格應為370()
        {
            //arrage
            var target = new ShoppingCart();

            var details = new List<CartDetail>()
            {
                new CartDetail(){
                ProductName = HarryPoter1,
                Amount = 1,
                Price = 100
                },
                new CartDetail(){
                ProductName = HarryPoter2,
                Amount = 1,
                Price = 100
                },
                new CartDetail(){
                ProductName = HarryPoter3,
                Amount = 2,
                Price = 100
                },
            };

            //act
            var expected = 370;
            var actual = target.CalcuatePrice(details);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 第一集買了一本_第二三集各買了兩本_價格應為460()
        {
            //arrage
            var target = new ShoppingCart();

            var details = new List<CartDetail>()
            {
                new CartDetail(){
                ProductName = HarryPoter1,
                Amount = 1,
                Price = 100
                },
                new CartDetail(){
                ProductName = HarryPoter2,
                Amount = 2,
                Price = 100
                },
                new CartDetail(){
                ProductName = HarryPoter3,
                Amount = 2,
                Price = 100
                },
            };

            //act
            var expected = 460;
            var actual = target.CalcuatePrice(details);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}