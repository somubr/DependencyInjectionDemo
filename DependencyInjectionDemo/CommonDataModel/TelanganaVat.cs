using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonDataModel
{
    public class TelanganaVat : IVatCalculator
    {

        public decimal GetVatPercentage()
        {
            return 12;
        }
    }
}
