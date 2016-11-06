using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3_Clases
{
    public class Pregunta
    {
        public string pregunta;
        public int dificultad;
        public List<Respuesta> respuestas = new List<Respuesta>();     

        public Pregunta(string pPregunta, int pDificultad)
        {
            pregunta = pPregunta;
            dificultad = pDificultad;
        }

        public bool verificarRespuesta(Respuesta pRespuesta)
        {
            return true;
        }
    }
}
