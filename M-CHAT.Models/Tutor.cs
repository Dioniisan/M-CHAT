using System;
using System.Text;
using System.Collections.Generic;

namespace M_CHAT.Models
{
    public class Tutor : BaseEntity
    {
        public int TutorID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }

        //Navega
        public ICollection<Ninio> Ninios { get; set; }

        public ICollection<Cuenta> Cuentas { get; set; }


    }
}
