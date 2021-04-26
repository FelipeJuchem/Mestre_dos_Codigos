using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Exercicio9.Testes
{
    
    public class InsertRemoveTestes
    {
        public InsertRemove insertRemove = new InsertRemove();
        List<int> lista = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        [Fact]
        public void DeveInserirDados()
        {
            //arranje
            List<int> listaVazia = new List<int>();
            var numero = 2;

            //act
            insertRemove.Inserir(listaVazia, numero);

            //assert
            Assert.NotEmpty(listaVazia);
        }

        [Fact]
        public void DeveInserirNoInicioDaLista()
        {
            //arranje
            var numero = 10;

            //act
            insertRemove.InserirNoInicioDaLista(lista, numero);

            //assert
            var resultado = lista.FirstOrDefault();
            Assert.Equal(numero, resultado);
        }

        [Fact]
        public void DeveInserirNoFimDaLista()
        {
            //arranje
            var numero = 10;

            //act
            insertRemove.InserirNoFimDaLista(lista, numero);

            //assert
            var resultado = lista.LastOrDefault();
            Assert.Equal(numero, resultado);
        } 

        [Fact]
        public void DeveRemoverPrimeiroDaLista()
        {
            //act
            insertRemove.RemoverPrimeiroDaLista(lista);

            //assert
            Assert.DoesNotContain(0, lista);
        }

        [Fact]
        public void DeveRemoverUltimoDaLista()
        {
            //act
            insertRemove.RemoverUltimoDaLista(lista);

            //assert
            Assert.DoesNotContain(9, lista);
        }
    }
}
