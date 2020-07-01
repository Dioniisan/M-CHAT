using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M_CHAT.Models;
using M_CHAT.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace M_CHAT.Pages
{
    public class RegistroModel : PageModel
    {
        private readonly IRepository<Tutor> repositorioTutor;
        private readonly IRepository<Ninio> repositorioNinio;
        private readonly IRepository<CentroE> repositorioCentroE;

        [BindProperty]
        public Tutor Tutor { get; set; }
        [BindProperty]
        public Ninio Ninio { get; set; }
        public CentroE CentroE { get; set; }
        [BindProperty]
        public Cuenta Cuenta { get; set; }
        public int TutorNuevo { get; set; }
        public RegistroModel(IRepository<Tutor> repositorioTutor, IRepository<Ninio> repositorioNinio, IRepository<CentroE> repositorioCentroE)
        {
            this.repositorioTutor = repositorioTutor;
            this.repositorioNinio = repositorioNinio;
            this.repositorioCentroE = repositorioCentroE;

        }
        public IActionResult OnGet(int id)
        {
            return Redirect("/SesionDetails");

        }
    }
}
