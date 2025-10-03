using ClassLibraryFrutas;
using System.Net.Http.Headers;
namespace TestProjectFrutas
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdicionarAprovar()
        {
            var adicionarFruta = new ClassListaFrutas(new List<string>());
            adicionarFruta.Adicionar("Ma�a");
            Assert.Equal("Ma�a", "Ma�a");
        }
        [Fact]
        public void TestAdicionarReprovado()
        {
            var adicionarFruta = new ClassListaFrutas(new List<string>());
            adicionarFruta.Adicionar("Ma�a");
            Assert.Equal("Ma�a", "Pera");
        }
    }
}