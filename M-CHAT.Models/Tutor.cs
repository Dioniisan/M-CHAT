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
        


        //Navega
        public ICollection<Ninio> Ninios { get; set; }

        //Referencias
        [ForeignKey("Cuenta")]
        public int CuentaId { get; set; }
        public Cuenta Cuenta { get; set; }

    }
}
