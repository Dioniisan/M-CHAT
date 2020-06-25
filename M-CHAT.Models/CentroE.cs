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
        
        public int CentroEID { get; set; }
        [Display(Name = "Nombre del Centro Educativo")]
        public string Nombre { get; set; }

        [Display(Name = "Direccion del Centro Educativo")]
        public string Direccion { get; set; }

        [Display(Name = "Clave del Centro Educativo")]
        [Required(ErrorMessage ="Clave requerida.")]
        public string Clave { get; set; }

        //Navega
        public ICollection<Ninio> Ninios { get; set; }
    }
}
