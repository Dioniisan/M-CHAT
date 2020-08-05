using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace M_CHAT.Models
{
    public class Pregunta : BaseEntity
    {
        public bool Tipo { get; set; }
        public string PreguntaRealizada { get; set; }
        [Required(ErrorMessage = "Version de la plantilla requerida")]
        [Display(Name = "Plantilla")]
        [ForeignKey("Plantilla")]
        public int PlantillaId { get; set; }
        public Plantilla Plantilla { get; set; }


    }
}
