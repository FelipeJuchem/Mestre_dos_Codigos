using Exercicio3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercicio3Testes
{
    [TestClass]
    public class ContaCorrenteTestes
    {
        private readonly ContaBancaria _contaBancaria;
        public ContaCorrenteTestes()
        {
            _contaBancaria = new ContaCorrente();
        }
        
        [TestMethod]
        public void DeveDepositar()
        {
            //arranje
            double valor = 19.80;

            //act
            _contaBancaria.Depositar(20.00);

            //assert
            Assert.AreEqual(valor, _contaBancaria.Saldo);
        }

        [TestMethod]
        public void DeveSacar()
        {
            //arraje
            _contaBancaria.Depositar(10.00);
            double valor = 8.6000000000000014;

            //act
            _contaBancaria.Sacar(1.0);

            //assert
            Assert.AreEqual(valor, _contaBancaria.Saldo);
        
        
        }

    }
}
