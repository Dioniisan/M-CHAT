using System;
using System.Collections.Generic;
using System.Text;
using M_CHAT.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace M_CHAT.Services
{
    public class ContainerRepository : /*SQLRepository<Tutor>,*/ IContainerRepository
    {
      
        AppDBContext context;
        public ContainerRepository(AppDBContext context)
        {
            this.context = context;
        }

        public Tutor GetNiniosbyTutor(int id)
        {
            context.Ninios.Include(x => x.CentroE).ToList();
            return context.Tutores.Include(x => x.Ninios).FirstOrDefault(x => x.Id == id) ?? new Tutor();

        }

        public Tutor GetTutor(int id)
        {
            return context.Tutores.Include(x => x.Ninios).FirstOrDefault(x => x.Id == id);
        }
        public Cuenta GetCuenta(int id)
        {
            return context.Cuentas.FirstOrDefault(x => x.Tutor.Id == id);
        }

        public Ninio GetNinio(int id)
        {
            return context.Ninios.Include(x => x.CentroE).FirstOrDefault(x => x.Id == id);
        }
        
        public Respuesta GetRespuesta(int ninio, int pregunta)
        {
            IEnumerable<Respuesta> respuestas;
            respuestas = context.Respuestas.AsEnumerable();
            Respuesta respuesta = new Respuesta();
            foreach (var item in respuestas)
            {
                if (ninio == item.NinioId && pregunta == item.PreguntaId)
                {
                    respuesta = item;
                }
                else
                {
                    respuesta.NinioId = ninio;
                    respuesta.PreguntaId = pregunta;
                }
            }
            return respuesta;
        } 
        public int InicioSesion(Cuenta cuenta)
        {
            var tutors = context.Tutores.Include(x => x.Cuenta).ToList();
            int numero = 0;
            foreach (var item in tutors)
            {
                if (cuenta.Contrasenia == item.Cuenta.Contrasenia && cuenta.Correo == item.Cuenta.Correo)
                {
                    numero = item.Id;

                }
            }
            return numero;
        }

        public IEnumerable<Respuesta> GetRespuestasbyNinio(int id)
        {
            return context.Respuestas.Include(x => x.Pregunta).Where(x => x.NinioId == id);
        }
    }
}
