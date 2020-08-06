using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M_CHAT.Models;
using M_CHAT.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace M_CHAT.Pages
{
    public class TestModel : PageModel
    {
        
        [BindProperty]
        public Respuesta Respuesta { get; set; }
        public readonly IRepository<Pregunta> preguntas;
        [BindProperty]
        public Pregunta pregunta { get; set; }
        public IEnumerable<Pregunta> Preguntas { get; set; }
        [BindProperty]
        public int x { get; set; }
        public readonly IRepository<Respuesta> repository;


        public IContainerRepository ContainerRepository;
        public void OnGet(int id, int Pregunta)
        {
            
            Respuesta = ContainerRepository.GetRespuesta(id, Pregunta);
            Preguntas = preguntas.GetAll();
            pregunta = preguntas.Get(Pregunta);

        }

        public TestModel(IRepository<Respuesta> repository, IRepository<Pregunta> preguntas, IContainerRepository containerRepository)
        {
            this.preguntas = preguntas;
            this.repository = repository;
            this.ContainerRepository = containerRepository;
        }

        public IActionResult OnPost()
        {
            if (Respuesta.ValorRespuesta != null)
            {
                if (Respuesta.Id >= 1)
                {
                    repository.Update(Respuesta);
                }
                else
                {
                    repository.Insert(Respuesta);
                }
            }
            
            if (x == 24)
            {
                return Page();
            }
            else if (x == 47)
            {
                return Redirect("/Resultados/?id=" + Respuesta.NinioId);
            }

            return Redirect("/Test/?id="+Respuesta.NinioId+"&Pregunta="+x);
        }
    }
}
