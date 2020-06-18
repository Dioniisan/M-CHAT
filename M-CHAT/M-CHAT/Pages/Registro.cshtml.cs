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
        public SelectList Ninios { get; private set; }
        //public EditModel(IContainerRepository repository)
        //{
        //    this.repository = repository;
        //}
        public IActionResult OnGet(int id)
        {
            Tutor = repository.Get(id);
            if (Tutor.Id == 0)
                return RedirectToPage("/NotFound");
            Ninios = new SelectList(repository.GetNinios(), nameof(Ninio.Id), nameof(Ninio.Nom_Comp));
            return Page();
        }
        public void OnGet()
        {
        }
    }
}
