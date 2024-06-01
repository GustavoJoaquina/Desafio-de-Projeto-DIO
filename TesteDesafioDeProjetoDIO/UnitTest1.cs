using DESAFIO_DE_PROJETO_DIO;

namespace TesteDesafioDeProjetoDIO
{
    public class UnitTest1
    {
        Calculadora calc = new Calculadora();

        [Fact]
        public void TestSomar()
        {
            int resultado = calc.Somar(1, 2);

            Assert.Equal(3, resultado);
        }

        [Fact]
        public void TesteSubtrair()
        {
            int resultado = calc.Subtrair(5, 2);

            Assert.Equal(3, resultado);
        }

        [Fact]
        public void TesteDividir() 
        {
            int resultado = calc.Dividir(10, 2);

            Assert.Equal(5, resultado);
        }

        [Fact]
        public void TesteDividirPor0() 
        {
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(5, 0)
            );
        }

        [Fact]
        public void TesteMultiplicar() 
        {
            int resultado = calc.Multiplicar(5, 2);

            Assert.Equal(10, resultado);
        }

        [Fact]
        public void TestarHistorico()
        {
            calc.Somar(1, 2);
            calc.Somar(6, 2);
            calc.Somar(1, 8);
            calc.Somar(1, 5);

            var lista = calc.VisualizarHistorico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }
    }
}