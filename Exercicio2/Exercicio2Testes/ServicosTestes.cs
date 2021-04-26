using Exercicio2Testes.DataBuilder;
using ListaFuncionarios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercicio2Testes
{
    [TestClass]
    public class ServicosTestes
    {
        private readonly Servicos _servicos;
        public ServicosTestes()
        {
            _servicos = new Servicos();
        }

        List<Funcionario> listaFuncionarios = new List<Funcionario>
        {
            FuncionarioTestDataBuilder.NewFuncionario1(),
            FuncionarioTestDataBuilder.NewFuncionario2(),
            FuncionarioTestDataBuilder.NewFuncionario3()
        };

        [TestMethod]
        public void DeveRetornarFuncionarioComMaiorSalario()
        {
            //act
            var resultado = _servicos.MaiorSalario(listaFuncionarios);

            //assert
            Assert.AreEqual(5000, resultado.Salario);
        }

        [TestMethod]
        public void DeveRetornarFuncionarioComMenorSalario()
        {
            //act
            var resultado = _servicos.MenorSalario(listaFuncionarios);

            //assert
            Assert.AreEqual(1000, resultado.Salario);
        }
    }
}
