using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3_Clases
{
    public interface FileData
    {
        List<Pregunta> listaPreguntasFile(int totalPreguntas);
        List<Respuesta> listaRespuestasFile();
    }
}
