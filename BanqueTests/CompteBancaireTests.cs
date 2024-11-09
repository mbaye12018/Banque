using CompteBanqueNS;
using Microsoft.VisualStudio.TestTools.UnitTesting; // Pour MSTest
namespace BanqueTests
{
    [TestClass]
    public class CompteBancaireTests
    {
        [TestMethod]
        public void VerifierDebitCompteCorrect()
        {
            // Arrange: Setup initial values
            double soldeInitial = 500000;
            double montantDebit = 400000;
            double soldeAttendu = 100000;
            var compte = new CompteBancaire("Pr. Abdoulaye Diankha", soldeInitial);

            // Act: Perform the debit operation
            compte.Debiter(montantDebit);

            // Assert: Check if the balance is as expected
            double soldeObtenu = compte.Balance;
            Assert.AreEqual(soldeAttendu, soldeObtenu, 0.001, "Compte débité incorrectement");
        }
    }
}
