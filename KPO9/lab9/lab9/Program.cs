using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            ReceiptCarComponent car = new EconomyCar();
            CarAccessoriesDecorator acc = new BasicAccessories(car);
            Console.WriteLine("The car brand is :" +acc.Compagny_Name()+"\nThe car costs : $" + acc.GetCost() +"\nThe Company address is "+ acc.Address());

            ReceiptCarComponent cc = new DeluxCar();
            CarAccessoriesDecorator ac = new SportsAccessories(cc);
            Console.WriteLine("The car brand is :" + ac.Compagny_Name() + "\nThe car costs : $" + ac.GetCost() + "\nThe Company address is " + ac.Address());


            ReceiptCarComponent car1 = new LuxuryCar();
            CarAccessoriesDecorator acc1 = new AdvancedAccessories(car1);
            Console.WriteLine("The car brand is :" + acc1.Compagny_Name() + "\nThe car costs : $" + acc1.GetCost() + "\nThe Company address is " + acc1.Address());
            Console.ReadKey();
        }
    }
}

