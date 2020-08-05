using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using M_CHAT.Services;
using M_CHAT.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace M_CHAT.Pages
{
    public class ModificarNinioModel : PageModel
    {
        public IRepository<Ninio> repository;
        public IRepository<CentroE> repositorycentro;
        [BindProperty]
        public Ninio Ninio { get; set; }
        [BindProperty]
        public CentroE CentroE { get; set; }
        [Required(ErrorMessage ="Foto requerida")]
        public IFormFile FotoNinio { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }
        public ModificarNinioModel(IRepository<Ninio> repository, IRepository<CentroE> repositorycentro, IWebHostEnvironment hostEnviroment)
        {
            this.repository = repository;
            this.repositorycentro = repositorycentro;
            this.HostEnvironment = hostEnviroment;
        }
        public void OnGet(int id)
        {
            Ninio = repository.Get(id);

            CentroE = repositorycentro.Get(Ninio.Id);
        }
        public IActionResult OnPost(int id, Ninio Ninio)
        {
            if (!ModelState.IsValid)
                return Page();

            if (FotoNinio != null)
            {
                if (!string.IsNullOrEmpty(Ninio.Foto))
                {
                    var filePath = Path.Combine(HostEnvironment.WebRootPath, "Images", Ninio.Foto);
                    System.IO.File.Delete(filePath);

                }
                Ninio.Foto = ProcessUploadFile();

            }

            repositorycentro.Update(CentroE);
            repository.Update(Ninio);
            return Redirect("/SesionDetails/?Id=" + Ninio.TutorID);

        }
        private string ProcessUploadFile()
        {
            if (FotoNinio == null)
                return string.Empty;
            var uploadFolder = Path.Combine(HostEnvironment.WebRootPath, "images");
            var fileName = $"{Guid.NewGuid()}_{FotoNinio.FileName}";
            var filePath = Path.Combine(uploadFolder, fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                FotoNinio.CopyTo(stream);
            }
            return fileName;
        }
    }
}