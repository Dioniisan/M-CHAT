using System;
using System.Collections.Generic;
using System.Text;

namespace M_CHAT.Models
{
    public class Respuesta : BaseEntity
    {
        public int RespuestaID { get; set; }
        public string Valor { get; set; }
        
        //Referencias
        ///Ninio
        ///Cuestionario
    }
}
