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
        Juego juego = new Juego();
        Pregunta oPregunta = new Pregunta("Pregunta1", 6);

        [SetUp]
        public void initTest()
        {
            juego.preguntas.Add(oPregunta);
            Respuesta respuesta1 = new Respuesta("Respuesta1", false);
            Respuesta respuesta2 = new Respuesta("Respuesta2", true);
            Respuesta respuesta3 = new Respuesta("Respuesta3", false);
            Respuesta respuesta4 = new Respuesta("Respuesta4", false);

            oPregunta.respuestas.Add(respuesta1);
            oPregunta.respuestas.Add(respuesta2);
            oPregunta.respuestas.Add(respuesta3);
            oPregunta.respuestas.Add(respuesta4);
        }
        
        static Pregunta[] PreguntaCases =
        {
            new Pregunta("Pregunta2", 2),
            new Pregunta("Pregunta3", 6),
            new Pregunta("Pregunta4", 1),
            new Pregunta("Pregunta5", 9)
        };

        [Test, TestCaseSource("PreguntaCases")]
        public void juego_agregarPregunta_correctamente(Pregunta pPregunta)
        {
            int totalPreguntas = juego.preguntas.Count;
            int resultadoFunction = juego.agregar_preguntas(pPregunta);

            Assert.Greater(resultadoFunction, totalPreguntas);
        }

        [Test]
        public void juego_editarPregunta_correctamente()
        {
            int totalPreguntas = juego.preguntas.Count;
            int resultadoFunction = juego.editar_preguntas(oPregunta);

            Assert.AreEqual(resultadoFunction, totalPreguntas);
        }

        [Test, TestCaseSource("PreguntaCases")]
        public void juego_borrarPregunta_correctamente(Pregunta pPregunta)
        {
            int totalPreguntas = juego.preguntas.Count;
            int resultadoFunction = juego.borrar_preguntas(pPregunta);

            Assert.Less(resultadoFunction, totalPreguntas);
        }

        [TestCase(false, 0)]
        [TestCase(true, 1)]
        [TestCase(false, 0)]
        public void juego_aumentarPuntuacion_Correctamente(Boolean pValor, int pPuntucionEsperada)
        {
            int puntuacionReturn = juego.aumentarPuntuacion(pValor);
            Assert.AreEqual(pPuntucionEsperada, puntuacionReturn);
        }

        [Test]
        public void juego_mostrarTotalPreguntas()
        {
            int totalPreguntas = juego.mostrarTotalPreguntas();
            Assert.Greater(totalPreguntas, 0);
        }
    }
}
