using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class EconomyCar : ReceiptCarComponent
    {
        public string Compagny_Name()
        {
            return " BMW";
        }
        public string Address()
        {
            return "Allemand 50 zurich";
        }
        public string GetDescription()
        {
            return " Economy Car";
        }
        public double GetCost()
        {
            return 450000;
        }
    }
    public class DeluxCar : ReceiptCarComponent
    {
        public string Compagny_Name()
        {
            return " Mercedes";
        }
        public string Address()
        {
            return "USA 50 zurich";
        }
        public string GetDescription()
        {
            return " Delux Car";
        }
        public double GetCost()
        {
            return 750000.0;
        }
    }

public class LuxuryCar : ReceiptCarComponent
            {
                public string Compagny_Name()
                {
                    return " Lamborghini";
                }
                public string Address()
                {
                    return "Japan xx5js";
                }
                public string GetDescription()
                {
                    return " Luxury Car";
                }
                public double GetCost()
                {
                    return 1000000.0;
                }


            }

        }
