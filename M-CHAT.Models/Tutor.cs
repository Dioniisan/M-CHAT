using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M_CHAT.Models
{
    public class Tutor : BaseEntity
    {
        [Display(Name ="Nombre", Prompt = "Carlos Garcia")]
        [Required(ErrorMessage = "Necesita escribir un nombre.")]
        public string Nombre { get; set; }
        [Display(Name = "Dirección", Prompt = "Calle 15A #569, Fracc. Maldivas")]
        [Required(ErrorMessage = "Necesita proporcionar una dirección.")]
        public string Direccion { get; set; }
        [Display(Name = "Correo Electronico", Prompt = "Ejemplo@correo.com")]
        [Required(ErrorMessage = "Necesita proporcionar un correo electronico valido.")]
        public string Correo { get; set; }
        [Display(Name = "Contraseña", Prompt = "Contraseña")]
        [Required(ErrorMessage = "Debe proporcionar una contraseña.")]
        public string Contrasenia { get; set; }
        public Cuenta Cuenta { get; set; }

        //Navega
        public ICollection<Ninio> Ninios { get; set; }

        //Referencias
        [ForeignKey("Cuenta")]
        public int CuentaId { get; set; }


    }
}
