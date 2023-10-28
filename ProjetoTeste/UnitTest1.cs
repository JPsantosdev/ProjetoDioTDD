namespace projetoteste;

public class UnitTest1
{
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TesteSomar(int val1, int val2, int res)
    {
        Calculadora _calc = new Calculadora();

        int resultado = _calc.somar(val1, val2);

        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TesteMultiplicar(int val1, int val2, int res)
    {
        Calculadora _calc = new Calculadora();

        int resultado = _calc.multiplicar(val1, val2);

        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData (8, 2, 6)]
    [InlineData (5, 4, 1)]
    public void TesteSubtrair(int val1, int val2, int res)
    {
        Calculadora _calc = new Calculadora();

        int resultado = _calc.subtrair(val1, val2);

        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData (2, 2, 1)]
    [InlineData (6, 2, 3)]
    public void TestDividir(int val1, int val2, double res)
    {
        Calculadora _calc = new Calculadora();

        double resultado = _calc.dividir(val1, val2);

        Assert.Equal(res, resultado);
    }

    [Fact]
    public void TesteDivisaoPorZero()
    {
        Calculadora _calc = new Calculadora();

        Assert.Throws<DivideByZeroException>();
    }

}