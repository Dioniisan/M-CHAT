using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M_CHAT.Models
{
    public class Ninio : BaseEntity
    {
        [Display(Name = "Nombre completo", Prompt = "Ernesto Alejandro Ruiz Poot")]
        [Required(ErrorMessage = "Debe proporcionar el nombre del niño.")]
        public string Nom_Comp { get; set; }
        [Display(Name = "CURP", Prompt = "AUAM630703HGTGRR02")]
        [Required(ErrorMessage = "Debe proporcionar el CURP del niño.")]
        public string CURP { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "Debe proporcionar la fecha de nacimiento del niño.")]
        public string Fecha_nac { get; set; }
        [Display(Name = "Edad", Prompt = "5")]
        [Required(ErrorMessage = "Debe proporcionar la edad del niño.")]
        public int Edad { get; set; }
        [Display(Name = "Genero")]
        [Required(ErrorMessage = "Debe proporcionar un genero al niño. Recuerde que solo hay dos generos.")]
        public string Genero { get; set; }
        [Display(Name = "Foto del niño", Prompt = "Foto del niño")]
        public string Foto { get; set; }

        public string Nacionalidad { get; set; } //voy a descartar esto aqui, en su lugar creare una enumeracion y un repositorio especifico.

        //Referencias
        [Display(Name = "Tutor")]
        [Required(ErrorMessage = "Informacion requerida en tutor.")]
        [ForeignKey("Tutor")]
        public int? TutorID { get; set; }
        public Tutor Tutor { get; set; }

        [Display(Name = "CentroE")]
        [Required(ErrorMessage = "Informacion requerida en centro educativo.")]
        [ForeignKey("CentroE")]
        public int CentroEID { get; set; }
        public CentroE CentroE { get; set; }

        //Navega
        ///Respuesta

    }
}
