using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto3_Clases;

namespace Proyecto3_Test
{
    [TestFixture]
    public class Juego_Test
    {
        Juego juego = new Juego(8);
        Pregunta oPregunta = new Pregunta("Pregunta2", 1, null);

        [SetUp]
        public void initTest()
        {
            juego.preguntas.Add(oPregunta);
        }
        
        static Pregunta[] PreguntaCases =
        {
            new Pregunta("Pregunta2", 2, null),
            new Pregunta("Pregunta3", 6, null),
            new Pregunta("Pregunta4", 1, null),
            new Pregunta("Pregunta5", 9, null)
        };


        [Test, TestCaseSource("PreguntaCases")]
        public void juego_agregarPregunta_correctamente(Pregunta pPregunta)
        {
            int totalPreguntas = juego.preguntas.Count;
            int resultadoFunction = juego.agregar_preguntas(pPregunta);

            Assert.Greater(resultadoFunction, totalPreguntas);
        }

        [Test, TestCaseSource("PreguntaCases")]
        public void juego_borrarPregunta_correctamente(Pregunta pPregunta)
        {
            int totalPreguntas = juego.preguntas.Count;
            int resultadoFunction = juego.borrar_preguntas(pPregunta);

            Assert.Less(resultadoFunction, totalPreguntas);
            Assert.IsFalse(juego.preguntas.Contains(pPregunta));
        }

        [Test]
        public void juego_editarPregunta_correctamente()
        {
            int totalPreguntas = juego.preguntas.Count;
            String enunciado = "Cambio de enunciado";
            int resultadoFunction = juego.editar_preguntas(oPregunta,enunciado);

            Assert.AreEqual(juego.preguntas[resultadoFunction].pregunta,enunciado);
        }

        [TestCase(false, 0)]
        [TestCase(true, 1)]
        [TestCase(false, 0)]
        public void juego_aumentarPuntuacion_Correctamente(Boolean pValor, int pPuntucionEsperada)
        {
            int puntuacionReturn = juego.aumentarPuntuacion(pValor);
            Assert.AreEqual(pPuntucionEsperada, puntuacionReturn);
        }

        [TestCase(9, 9)]
        [TestCase(1000, 1000)]
        [TestCase(0, 0)]
        [TestCase(-1, 0)] //Se ingresa # negativo se espera que quede en 0
        public void juego_ContructorJuego(int pTotalPreguntas,int pResultadoEsperado)
        {
            Juego testJuego = new Juego(pTotalPreguntas);
            Assert.AreEqual(pResultadoEsperado, testJuego.total_preguntas);
        }

        [Test]
        public void juego_mostrarTotalPreguntas()
        {
            int totalPreguntas = juego.mostrarTotalPreguntas();
            Assert.Greater(totalPreguntas, 0);
        }


        [Test]
        public void checkExtension()
        {
            MockExtensionService mockobject = new MockExtensionService();
            ExtensionAnalyzer analyzer = new ExtensionAnalyzer(mockobject);
            analyzer.ExtensionCheck("fileData.txt");

            Assert.AreEqual(mockobject.ErrorMessage, "Tipo Incorrecto de Archivo");
        }
    }
}
