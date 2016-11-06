using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3_Clases
{
    class Juego
    {
        int total_preguntas;
        int puntuacion;
        List<Pregunta> preguntas = new List<Pregunta>();


        public int agregar_preguntas(Pregunta pPregunta)
        {
            return preguntas.Count; /*puede ser count +1*/
        }

        public int editar_preguntas()
        {
            return preguntas.Count; 

        }

        public int borrar_preguntas()
        {
            return preguntas.Count; /*puede ser count -1*/

        }

        public int aumentarPuntuacion(Boolean pValor)
        {
            if (pValor) puntuacion++;
            return puntuacion;
        }

    }


}
