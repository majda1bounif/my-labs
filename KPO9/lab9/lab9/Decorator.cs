using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
public abstract class CarAccessoriesDecorator : ReceiptCarComponent
    {
        
        /// <summary>
        ///  here is the abstract decorator
        /// </summary>
        private ReceiptCarComponent car;
        public CarAccessoriesDecorator(ReceiptCarComponent aCar)
        {
            this.car = aCar;
        }
        public virtual string Compagny_Name()
        {
            return this.car.Compagny_Name();
        }
        public virtual string Address()
        {
            return this.car.Address();
        }
        public virtual string GetDescription()
        {
            return this.car.GetDescription();
        }
        public virtual double GetCost()
        {
            return this.car.GetCost();
        }
    }




    /// <summary>
    ///  Concrete Decorator A
    /// </summary>
    public class BasicAccessories : CarAccessoriesDecorator
    {
        public BasicAccessories(ReceiptCarComponent aCar) : base(aCar)
        {
        }
        public override string Compagny_Name()
        {
            return base.Compagny_Name();
        }
        public override string Address()
        {
            return base.Address();
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " Basic accessories package";
        }
        public override double GetCost()
        {
            return base.GetCost() + 6000.0;
        }
    }

        ///  Concrete Decorator B
        public class AdvancedAccessories : CarAccessoriesDecorator
        {
            public AdvancedAccessories(ReceiptCarComponent aCar) : base(aCar)
            {
            }
            public override string Compagny_Name()
            {
                return base.Compagny_Name();
            }
            public override string Address()
            {
                return base.Address();
            }
            public override string GetDescription()
            {
                return base.GetDescription() + " Advanced accessories package";
            }
            public override double GetCost()
            {
                return base.GetCost() + 10000.0;
            }

        }

            ///  Concrete Decorator C
            public class SportsAccessories : CarAccessoriesDecorator
            {
                public SportsAccessories(ReceiptCarComponent aCar) : base(aCar)
                {
                }
                public override string Compagny_Name()
                {
                    return base.Compagny_Name();
                }
                public override string Address()
                {
                    return base.Address();
                }
                public override string GetDescription()
                {
                    return base.GetDescription() + " Sports accessories package";
                }
                public override double GetCost()
                {
                    return base.GetCost() + 15000.0;
                }
            }
        }
   


