using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var name = new Name("Camila", "Nunes");
            var document = new Document("37519578801", EDocumentType.CPF);
            var email = new Email("cvn.camila@gmail.com");
            var address  = new Address("Rua1", "123", "Bairro", "Cidade", "SP", "BR", "13205430");
            var student = new Student(name, document, email);
            var subscription = new Subscription(null);
            var payment = new PayPalPayment("12345678",DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "CN WEB DESIGN", address, document, email);

            subscription.AddPayment(payment);
            student.AddSubscription(subscription);
            student.AddSubscription(subscription);

            Assert.IsTrue(student.Invalid);
        }

        //[TestMethod]
        public void ShouldReturnErrorWhenHadSubscriptionHasNoPayment()
        {

        }

        //[TestMethod]
        public void ShouldReturnSuccessWhenHadNoActiveSubscription()
        {
           //Assert.Fail();
        }
    }
}
