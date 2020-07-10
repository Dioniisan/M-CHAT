using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace M_CHAT.Models
{
    public class CentroE : BaseEntity
    {
        
        [Display(Name = "Nombre del Centro Educativo", Prompt ="Jardin de niños Fidel Velazquez.")]
        [Required(ErrorMessage = "Debe proporcionar el nombre del centro educativo.")]
        public string Nombre { get; set; }

        [Display(Name = "Direccion del Centro Educativo", Prompt = "124358ABC832")]
        [Required(ErrorMessage = "Debe proporcionar una clave del centro educativo")]
        public string Direccion { get; set; }

        [Display(Name = "Clave del Centro Educativo", Prompt = "")]
        [Required(ErrorMessage ="Clave requerida.")]
        public string Clave { get; set; }

        //Navega
        public ICollection<Ninio> Ninios { get; set; }
    }
}
