using System;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(   string transactionCode, 
                                DateTime paidDate, 
                                DateTime expireDate, 
                                decimal total,
                                decimal totalPaid, 
                                string payer, 
                                string adress, 
                                string document, 
                                string email
                            ) :base (
                                paidDate, 
                                expireDate, 
                                total, 
                                totalPaid, 
                                payer, 
                                adress, 
                                document, 
                                email
                            )
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}