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

        public bool verificarListaValida(List<Respuesta> pRespuesta)
        {
            int countTrue = 0;
            int countFalse = 0;
            bool answ;
            for (int i =0; i < 4; i++)
            {
                if (pRespuesta[i].valor) countTrue++;
                else countFalse+=1;
            }
            if (countTrue == 1 && countFalse == 3) answ = true;
            else answ = false;
            return answ;
        }
    }
}
