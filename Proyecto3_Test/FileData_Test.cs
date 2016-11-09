using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto3_Clases;
using Rhino.Mocks;

namespace Proyecto3_Test
{
    [TestFixture]
    public class FileData_Test
    {
        List<Respuesta> respuestas = new List<Respuesta>();

        [SetUp]
        public void initTest()
        {
            Respuesta respuesta1 = new Respuesta("Respuesta1", false);
            Respuesta respuesta2 = new Respuesta("Respuesta2", true);
            Respuesta respuesta3 = new Respuesta("Respuesta3", false);
            Respuesta respuesta4 = new Respuesta("Respuesta4", false);

            respuestas.Add(respuesta1);
            respuestas.Add(respuesta2);
            respuestas.Add(respuesta3);
            respuestas.Add(respuesta4);
        }

        [Test]
        public void fileData_listaPreguntasFile_LoadCorrect()
        {
            var fileServiceMock = MockRepository.GenerateMock<FileData>();

            List<Pregunta> listaPreguntas = new List<Pregunta>(3);

            var pregunta1 = new Pregunta("Pregunta1", 1, respuestas);
            var pregunta2 = new Pregunta("Pregunta2", 4, respuestas);
            var pregunta3 = new Pregunta("Pregunta3", 9, respuestas);

            listaPreguntas[0] = pregunta1;
            listaPreguntas[1] = pregunta2;
            listaPreguntas[2] = pregunta3;

            fileServiceMock.Stub(x => x.listaPreguntasFile(3)).IgnoreArguments().Return(listaPreguntas);

            Juego newGame = new Juego(3);

            Assert.AreEqual(newGame.preguntas.Count, newGame.total_preguntas);

        }
    }
}
