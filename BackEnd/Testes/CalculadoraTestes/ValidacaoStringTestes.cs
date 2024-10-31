using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacaoStringTestes
    {
        private ValidacaoString _validacaoString;

        public ValidacaoStringTestes()
        {
            _validacaoString = new ValidacaoString();
        }

        [Fact]
        public void ContarCaracteres()
        {
            // Arrange
            string texto = "Teste";

            // Act
            int resultado = _validacaoString.ContarCaracter(texto);

            // Assert
            Assert.Equal(5, resultado);
        }
    }
}