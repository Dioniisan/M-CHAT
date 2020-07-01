using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using M_CHAT.Models;

namespace M_CHAT.Services
{
    public interface IContainerRepository /*: IRepository<Tutor>*/
    {
        //public IEnumerable<Tutor> GetTutores();
        //public IEnumerable<Ninio> GetNinios();
        public Tutor GetNiniosbyTutor(int id);
        public Ninio GetNinio(int id);
        public IEnumerable<Respuesta> GetRespuestasbyNinio(int id);
        public int InicioSesion(Cuenta cuenta);
    }
}
