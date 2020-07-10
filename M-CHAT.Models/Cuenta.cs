using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace M_CHAT.Models
{
    public class Cuenta : BaseEntity
    {
        [Display(Name = "Correo Electronico", Prompt = "Ejemplo@correo.com")]
        [Required(ErrorMessage = "Necesita proporcionar un correo electronico valido.")]
        public string Correo { get; set; }
        [Display(Name = "Contraseña", Prompt = "Contraseña")]
        [Required(ErrorMessage = "Debe proporcionar una contraseña.")]
        public string Contrasenia { get; set; }

        //Referencias
        public Tutor Tutor { get; set; }
        //public Administrador Administrador { get; set; }
    }
}
