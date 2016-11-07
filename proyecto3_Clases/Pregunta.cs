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
        public List<Respuesta> respuestas = new List<Respuesta>(4);     

        public Pregunta(string pPregunta, int pDificultad)
        {
            pregunta = pPregunta;
            dificultad = pDificultad;
        }

        public bool agregarRespuesta(List<Respuesta> pRespuestas)
        {
            if (pRespuestas.Count != 4) { return false; }
            else {
                respuestas = pRespuestas;
                return true;
                }

        }
        public bool verificarRespuesta(Respuesta pRespuesta)
        {
            return true;
        }
    }
}
