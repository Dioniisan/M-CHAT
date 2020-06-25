using System;
using System.Collections.Generic;
using System.Text;

namespace M_CHAT.Models
{
    public class Cuestionario
    {
        public int CuestionarioID { get; set; }
        public int PreguntaID { get; set; }
        public bool Respuesta { get; set; }

        //Referencias
        ///Plantilla

        //Navega
        ///Pregunta
        ///Respuesta
    }
}
