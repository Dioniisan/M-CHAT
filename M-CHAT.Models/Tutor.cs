using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M_CHAT.Models
{
    public class Tutor : BaseEntity
    {
        public int TutorID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Contrase { get; set; }

        //Referencias
        [Display(Name = "Niño")]
        [Required(ErrorMessage = "Informacion requerida en niño.")]
        [ForeignKey("Ninio")]
        public int? NinioID { get; set; }
        public Ninio Ninio { get; set; }


    }
}
