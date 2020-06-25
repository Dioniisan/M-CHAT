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
        private readonly IContainerRepository repository;
        public Tutor Tutor { get; private set; }
        public Ninio Ninio { get; private set; }
        public CentroE CentroE { get; private set; }
        public RegistroModel(IContainerRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult OnGet(int id)
        {
            Tutor = repository.Get(id);

        }
    }
}
