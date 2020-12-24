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
            var email = new Email("cvn.camila#gmail.com");
            var student = new Student(name, document, email);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenHadNoActiveSubscription()
        {
           Assert.Fail();
        }
    }
}
