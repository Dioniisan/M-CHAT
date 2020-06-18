using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M_CHAT.Models
{
    public class Ninio : BaseEntity
    {
        public int NinioID { get; set; }
        public string Nom_Comp { get; set; }
        public string CURP { get; set; }
        public string Fecha_nac { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public string Foto { get; set; }

        //Referencias
        [Display(Name = "Tutor")]
        [Required(ErrorMessage = "Informacion requerida en tutor.")]
        [ForeignKey("Tutor")]
        public int? TutorID { get; set; }
        public Tutor Tutor { get; set; }

        [Display(Name = "CentroE")]
        [Required(ErrorMessage = "Informacion requerida en centro educativo.")]
        [ForeignKey("CentroE")]
        public int? CentroEID { get; set; }
        public CentroE CentroE { get; set; }

    }
}
