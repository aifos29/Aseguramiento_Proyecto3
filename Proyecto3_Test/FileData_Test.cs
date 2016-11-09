using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto3_Clases;
using NSubstitute;

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
        public void fileData_fileExtension_LoadCorrect()
        {
            var fileData = Substitute.For<FileData>();
        }
    }
}
