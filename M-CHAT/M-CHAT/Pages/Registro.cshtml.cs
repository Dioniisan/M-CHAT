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

        public Tutor Tutor { get; private set; }
        public Ninio Ninio { get; private set; }
        public CentroE CentroE { get; private set; }
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
