using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3_Clases
{
    class Pregunta
    {
        string pregunta;
        int dificultad;
        List<Respuesta> respuestas = new List<Respuesta>();     

        public bool verificarRespuesta(Respuesta pRespuesta)
        {
            return true;
        }
    }
}
