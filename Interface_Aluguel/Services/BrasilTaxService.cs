using System;
using System.Collections.Generic;
using System.Text;
using Interface_Aluguel.Entities;

namespace Interface_Aluguel.Services
{
    class BrasilTaxService : ITaxService;
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * .20;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
