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
    class Pregunta_Test
    {
        Juego juego = new Juego(8);
        Pregunta oPregunta = new Pregunta("Pregunta1", 6);
        List<Respuesta> listaRespuestas = new List<Respuesta>(4);
        [SetUp]
        public void initTest()
        {
            juego.preguntas.Add(oPregunta);
            Respuesta respuesta1 = new Respuesta("Respuesta1", false);
            Respuesta respuesta2 = new Respuesta("Respuesta2", true);
            Respuesta respuesta3 = new Respuesta("Respuesta3", false);
            Respuesta respuesta4 = new Respuesta("Respuesta4", false);

            listaRespuestas.Add(respuesta1);
            listaRespuestas.Add(respuesta2);
            listaRespuestas.Add(respuesta3);
            listaRespuestas.Add(respuesta4);
        }

        static Pregunta[] PreguntaCases =
        {
            new Pregunta("Pregunta2", 2),
            new Pregunta("Pregunta3", 6),
            new Pregunta("Pregunta4", 1),
            new Pregunta("Pregunta5", 9)
        };


        [TestCase("Esto es una pregunta?", "Esto es una pregunta?")]
        [TestCase("Esto es NO una pregunta", "Esto es NO una pregunta")]

        public void Pregunta_ConstructorPregunta(string pPregunta, int pDificultad,string resultadoEsperado)
        {
            Pregunta testPregunta = new Pregunta(pPregunta, 1);
            Assert.AreEqual(resultadoEsperado, testPregunta.pregunta);
        }
        
        public void Pregunta_agregarRespuesta_Correctamente(List<Respuesta> pRespuestas,bool resultadoEsperado)
        {
            bool resultado = oPregunta.agregarRespuesta(pRespuestas);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [Test]
        public void Pregunta_ListaRespuestaValida()
        {
            bool respuesta = oPregunta.verificarListaValida(listaRespuestas);
            Assert.True(respuesta);
        }
    

    }
}
