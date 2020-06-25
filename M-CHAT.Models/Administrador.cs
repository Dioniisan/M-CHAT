using System;
using System.Collections.Generic;
using System.Text;

namespace M_CHAT.Models
{
    public class Administrador : BaseEntity
    {
        public int AdministradorID { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }

        //Navega
        ///Cuenta
    }
}
