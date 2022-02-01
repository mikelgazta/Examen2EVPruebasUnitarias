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
        public void TestName1()
        {
            // Given
            var sis=new Sistema();
            var param=15;
            var esperado="metaverso";
            // When
            var result=sis.Metaverso(param);
            // Then
            Assert.Equal(result,esperado);
        }
        [Fact]
        public void TestName2()
        {
            // Given
            var sis=new Sistema();
            var param=5;
            var esperado="meta";
            // When
            var result=sis.Metaverso(param);
            // Then
            Assert.Equal(result,esperado);
        }
        [Fact]
        public void TestName3()
        {
            // Given
            var sis=new Sistema();
            var param=3;
            var esperado="verso";
            // When
            var result=sis.Metaverso(param);
            // Then
            Assert.Equal(result,esperado);
        }
        [Fact]
        public void TestName4()
        {
            // Given
            var sis=new Sistema();
            var param=4;
            var esperado="4";
            // When
            var result=sis.Metaverso(param);
            // Then
            Assert.Equal(result,esperado);
        }
        [Fact]
        public void TestName5()
        {
            // Given
            var sis=new Sistema();
            int [] param={15,5,3,4};
            // When
            string  esperado= "metaversometaverso4";
            string result=sis.Metaverso2(param);
            // Then
            Assert.Equal(result,esperado);
        }
    }
}