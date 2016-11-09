using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3_Clases
{
    public class Juego
    {
        public int total_preguntas;
        public int puntuacion;
        public List<Pregunta> preguntas = new List<Pregunta>();

        public int agregar_preguntas(Pregunta pPregunta)
        {
            preguntas.Add(pPregunta);
            return preguntas.Count; 
        }

        public int editar_preguntas(Pregunta pPregunta)
        {
            return preguntas.Count; 

        }

        public int borrar_preguntas(Pregunta pPregunta)
        {
            preguntas.Remove(pPregunta);
            return preguntas.Count; 
        }

        public int aumentarPuntuacion(Boolean pValor)
        {
            if (pValor) puntuacion++;
            return puntuacion;
        }

        public int mostrarTotalPreguntas()
        {
            total_preguntas = preguntas.Count;
            return total_preguntas;
        }

        public Juego(int totalPreguntas)
        {
            total_preguntas = totalPreguntas;
        }
    }


}
