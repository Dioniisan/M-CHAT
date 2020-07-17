using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using M_CHAT.Models;
using M_CHAT.Services;

namespace M_CHAT.Pages
{
    public class Index1Model : PageModel
    {
        private readonly IContainerRepository repository;

        public Tutor Ninios { get; private set; }

        [BindProperty]
        public Tutor Tutor { get; set; }
        [BindProperty]
        public Ninio Ninio { get; set; }
        public int NinioNuevo { get; set; }
        public CentroE CentroE { get; set; }
        [BindProperty]
        public Cuenta Cuenta { get; set; }
        public int TutorNuevo { get; set; }
        public void OnGet(int id)
        {
            Ninios = repository.GetNiniosbyTutor(id);
            ViewData["Tutor"] = id;
        }

        public Index1Model(IContainerRepository repository)
        {
            this.repository = repository;
        }
    
    }


}
