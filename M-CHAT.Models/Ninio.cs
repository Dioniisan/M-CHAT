using System;
using System.Collections.Generic;
using System.Text;

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

        //Navega
        public ICollection<Tutor> Tutors { get; set; }
        public ICollection<CentroE> CentrosE { get; set; }

    }
}
