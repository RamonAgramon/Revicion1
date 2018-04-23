using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Suma()
        {
            int[] Numeros = { 5, 7, 8, 8, 9, 9, 9, 9, 10, 10 };
            int Resultado = 84;
            Arimetrica x = new Arimetrica();
            var Suma = x.Suma(Numeros);
            Assert.AreEqual(Resultado, Suma);
        }
        [Test]
        public void Promedio()
        {
            double[] Numeros = { 5, 7, 8, 8, 9, 9, 9, 9, 10, 10 };
            double esperado = 8.4;
            Arimetrica x = new Arimetrica();
            var Promedio = x.Promedio(Numeros);
            Assert.AreEqual(esperado, Promedio);
        }
        [Test]
        public void Moda()
        {
            int[] Numeros = { 5, 7, 8, 8, 9, 9, 9, 9, 10, 10 };
            int Resultado = 9;
            Arimetrica x = new Arimetrica();
            var Promedio = x.Moda(Numeros);
            Assert.AreEqual(Resultado, Promedio);
        }
        [Test]
        public void Medaina()
        {
            int[] Numeros = { 5, 7, 8, 8, 9, 9, 9, 9, 10, 10 };
            int Resultado = 9;
            Arimetrica x = new Arimetrica();
            var Promedio = x.Mediana(Numeros);
            Assert.AreEqual(Resultado, Promedio);
        }
    }
}

