using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace M_CHAT.Models
{
    public class Cuenta : BaseEntity
    {
        [Display(Name ="Correo Electronico")]
        public string Correo { get; set; }
        [Display(Name ="Contraseña")]
        public string Password { get; set; }

        //Referencias
        ///Tutor
        ///Administrador
    }
}
