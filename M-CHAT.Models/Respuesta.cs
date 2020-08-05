﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace M_CHAT.Models
{
    public class Respuesta : BaseEntity
    {
  
        public bool? ValorRespuesta { get; set; }

        [Required(ErrorMessage = "pregunta a responder requerida")]
        [Display(Name = "Pregunta")]
        [ForeignKey("Pregunta")]
        public int PreguntaId { get; set; }
        public Pregunta Pregunta { get; set; }
        [Required(ErrorMessage = "Niño requerido")]
        [Display(Name = "Niño")]
        [ForeignKey("Ninio")]
        public int NinioId { get; set; }
        public Ninio Ninio { get; set; }
    }
}
