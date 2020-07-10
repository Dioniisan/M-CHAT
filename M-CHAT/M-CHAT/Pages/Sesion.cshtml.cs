using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.RazorPages;
using M_CHAT.Models;
using M_CHAT.Services;

namespace M_CHAT.Pages
{
    public class SesionModel : PageModel
    {
        private readonly ILogger<SesionModel> _logger;
        public IContainerRepository repository;

        [BindProperty]
        public Cuenta Cuenta { get; set; }

        public int cont;
        public void OnGet()
        {
        }
        public SesionModel(ILogger<SesionModel> logger, IContainerRepository repository)
        {
            _logger = logger;
            this.repository = repository;
        }

        public IActionResult OnPost()
        {
            cont = repository.InicioSesion(Cuenta);

            return Redirect("/SesionDetails");
        }
    }
}
