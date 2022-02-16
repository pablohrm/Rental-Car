using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Interface_Aluguel.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        //Abaixo trata-se de uma propriedade calculada, 
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return ($"Basic payments: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}, \nTax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}, \nTotalPayments: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
