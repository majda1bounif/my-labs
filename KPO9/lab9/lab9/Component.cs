using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public interface ReceiptCarComponent
    {
        string Compagny_Name();
        string Address();
        string GetDescription();
        double GetCost();
    }
}