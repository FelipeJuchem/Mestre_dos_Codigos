using RefOut;
using System;
using Xunit;

namespace RefOutTestes
{
    public class UnitTest1
    {
        [Fact]
        public void DeveMudarNomeParaAlan()
        {
            //arranje
            var objeto = new Objeto();

            //act
            objeto.mudarNomeParaAlan(ref objeto);

            Assert.Equal("Alan", objeto.Nome);
        }
    }
}
