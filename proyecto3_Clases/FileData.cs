using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using Moq;

namespace Proyecto3_Clases
{
    public interface FileData
    {
        Pregunta returnPregunta(string pregunta, int dificultad, List<Respuesta> respuestas);
        List<Pregunta> crearListaPregunta(Pregunta pPregunta);
        Respuesta returnRespuestaCorrecta(Pregunta pPregunta);
    }
}
