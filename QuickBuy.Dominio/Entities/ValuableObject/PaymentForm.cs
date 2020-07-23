using QuickBuy.Dominio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities.ValuableObject
{
    //Essa classe não é considerada entidade porque ela serve de apoio a classe de request ou pedido
    public class PaymentForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Verificando se é boleto:
        public bool IsBankSlip 
        {
            //Se o id de PaymentForm for igual ao enum de bankSlip, então é boleto:
            get { return Id == (int) PaymentTypeForm.BankSlip; }
        }

        public bool IsCreditCard
        {
            //Se o id de PaymentForm for igual ao enum de CreditCard, então é cartao:
            get { return Id == (int)PaymentTypeForm.CreditCard; }
        }

        public bool IsBankDeposit
        {
            //Se o id de PaymentForm for igual ao enum de CreditCard, então é cartao:
            get { return Id == (int)PaymentTypeForm.BankDeposit; }
        }

        public bool IsUndefined
        {
            //Se o id de PaymentForm for igual ao enum de CreditCard, então é cartao:
            get { return Id == (int)PaymentTypeForm.Undefined; }
        }
    }
}
