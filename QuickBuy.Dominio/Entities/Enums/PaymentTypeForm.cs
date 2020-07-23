using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities.Enums
{
    public enum PaymentTypeForm
    {
        Undefined = 0,
        BankSlip = 1, //boleto bancario
        CreditCard = 2,
        BankDeposit = 3
    }
}
