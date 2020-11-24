using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var subscription = new Subscription(null);
            var student = new Student ("Camila", "Nunes", "375.195.788-01", "cvn.camila@gmail.com");
            student.AddSubscription(subscription);
        }
    }
}
