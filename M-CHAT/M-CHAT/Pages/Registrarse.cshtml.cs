using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using M_CHAT.Services;
using M_CHAT.Models;

namespace M_CHAT.Pages
{
    public class RegistrarseModel : PageModel
    {
        private readonly IRepository<Tutor> repositorioTutor;
        private readonly IRepository<Ninio> repositorioNinio;
        private readonly IRepository<CentroE> repositorioCentroE;
        private readonly IRepository<Cuenta> repositorioCuenta;

        [BindProperty]
        public Tutor Tutor { get; set; }
        [BindProperty]
        public Ninio Ninio { get; set; }
        public int NinioNuevo { get; set; }
        public CentroE CentroE { get; set; }
        [BindProperty]
        public Cuenta Cuenta { get; set; }
        public int TutorNuevo { get; set; }
        public RegistrarseModel(IRepository<Tutor> repositorioTutor, IRepository<Ninio> repositorioNinio, IRepository<CentroE> repositorioCentroE, IRepository<Cuenta> repositorioCuenta)
        {
            this.repositorioTutor = repositorioTutor;
            this.repositorioNinio = repositorioNinio;
            this.repositorioCentroE = repositorioCentroE;
            this.repositorioCuenta = repositorioCuenta;

        }
        //public IActionResult OnGet(int id)
        //{
        //    Ninio.TutorID = id;
        //    return Redirect("/SesionDetails");

        //}

        public IActionResult OnPost()
        {
            Tutor.Cuenta = Cuenta;
            repositorioCuenta.Insert(Cuenta);
            TutorNuevo = repositorioTutor.Insert(Tutor);
            Ninio.TutorID = Tutor.Id;
            //repositorioCentroE.Insert(CentroE);
            NinioNuevo = repositorioNinio.Insert(Ninio);
            return Redirect("/SesionDetails");

        }
    }
}
