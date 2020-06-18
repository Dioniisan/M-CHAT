using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M_CHAT.Models
{
    public class CentroE : BaseEntity
    {
        public int CentroEID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Clave { get; set; }

        //Navega
        public ICollection<Ninio> Ninios { get; set; }
    }
}
