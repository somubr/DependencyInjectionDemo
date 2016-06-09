using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonDataModel
{
    public interface IVatCalculator
    {
        decimal GetVatPercentage();
    }
}
