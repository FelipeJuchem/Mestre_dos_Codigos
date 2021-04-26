using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Exercicio9.Testes
{
    public class BuscaTestes
    {
        public Busca buscar = new Busca();
        List<int> lista = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        [Fact]
        public void DeveBuscarOsPares()
        {
            //act
            var resultado = buscar.BuscaPares(lista);

            //assert
            Assert.DoesNotContain(1, resultado);
            Assert.DoesNotContain(3, resultado);
            Assert.DoesNotContain(5, resultado);
            Assert.DoesNotContain(7, resultado);
            Assert.DoesNotContain(9, resultado);
        }

        [Fact]
        public void DeveBuscarPrimeiro()
        {
            //act
            var resultado = buscar.PrimeiroDaLista(lista);

            //assert
            var valorEsperado = 0;
            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void DeveBuscarUltimo()
        {
            //act
            var resultado = buscar.UltimoDaLista(lista);

            //assert
            var valorEsperado = 9;
            Assert.Equal(valorEsperado, resultado);
        }
    }
}
