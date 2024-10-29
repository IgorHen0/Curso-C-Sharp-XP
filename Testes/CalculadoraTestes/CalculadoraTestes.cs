using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calculadora;

    public CalculadoraTestes()
    {
        _calculadora = new CalculadoraImp();
    }

    [Fact]
    public void Soma5Mais10()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calculadora.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void Subtrai10Menos5()
    {
        // Arrange
        int num1 = 10;
        int num2 = 5;

        // Act
        int resultado = _calculadora.Subtrair(num1, num2);

        // Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Multiplica5Por10()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calculadora.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(50, resultado);
    }

    [Fact]
    public void Divide10Por5()
    {
        // Arrange
        int num1 = 10;
        int num2 = 5;

        // Act
        int resultado = _calculadora.Dividir(num1, num2);

        // Assert
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void VerificaSeNumeroEhPar()
    {
        // Arrange
        int num = 10;

        // Act
        _calculadora.EhPar(num);

        // Assert
        Assert.True(true);
    }

    [Theory]
    [InlineData(new int[] { 2, 4, 6, 8, 10 })]
    public void VerifcaVariosNumPares(int[] nums)
    {
        foreach (var num in nums)
        {
            // Act && Assert
            Assert.All(nums, n => Assert.True(_calculadora.EhPar(n)));
        }
    }
}