using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab9;
using NUnit.Framework;


namespace ClassLibrary1
{
    [TestFixture]
    public class Component 
    {
       [Test]
       public void TestEconomyCar()
        {
            ReceiptCarComponent car = new EconomyCar();
            CarAccessoriesDecorator acc = new BasicAccessories(car);
            string actual1 = acc.GetDescription();
            string expected1 = " Economy Car Basic accessories package";
            Assert.AreEqual(actual1, expected1);
        }
        [Test]
        public void TestDeluxCar()
        {
            ReceiptCarComponent car = new DeluxCar();
            CarAccessoriesDecorator acc = new BasicAccessories(car);
            string actual1 = acc.GetDescription();
            string expected1 = " Delux Car Basic accessories package";
            Assert.AreEqual(actual1, expected1);
        }
        [Test]
        public void TestluxCar()
        {
            ReceiptCarComponent car = new LuxuryCar();
            CarAccessoriesDecorator acc = new BasicAccessories(car);
            string actual1 = acc.GetDescription();
            string expected1 = " Luxury Car Basic accessories package";
            Assert.AreEqual(actual1, expected1);
        }
        [Test]
        public void TestCostCars()
        {
            ReceiptCarComponent car1 = new DeluxCar();
            CarAccessoriesDecorator acc1 = new AdvancedAccessories(car1);
            ReceiptCarComponent  car2= new LuxuryCar();
            CarAccessoriesDecorator acc2 = new SportsAccessories(car2);
            ReceiptCarComponent car3 = new  EconomyCar();
            CarAccessoriesDecorator acc3 = new BasicAccessories(car3);

            var actual1 = acc1.GetCost();
            double expected1 = 760000.0;

            var actual2 = acc2.GetCost();
            double expected2 = 1015000.0;


            var actual3 = acc3.GetCost();
            double expected3 = 456000.0;


            Assert.AreEqual(actual1, expected1);
            Assert.AreEqual(actual2, expected2);
            Assert.AreEqual(actual3, expected3);

        }
  

    }
}
