using Xunit;

namespace Metaverso
{

    public class SistemaTest
    {

        [Fact]
        public void SaludoTest()
        {
            // Given
            var sis = new Sistema();
            var param = "Santi";
            var esperado = $"MAL Saludos {param}!";
            // When
            var result = sis.Saludo(param);
            // Then
            Assert.Equal(result, esperado);
        }
        [Fact]
        public void TestName()
        {
            // Given
            var sis=new Sistema();
            var param=15;
            var esperado="Metaverso";
            // When
            var result=sis.Metaverso(param);
            // Then
            Assert.Equal(result,esperado);
        }
    }
}