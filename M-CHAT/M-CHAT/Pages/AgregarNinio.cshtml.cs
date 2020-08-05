using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using M_CHAT.Services;
using M_CHAT.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace M_CHAT.Pages
{
    public class AgregarNinioModel : PageModel
    {
        private readonly IRepository<Tutor> repositorioTutor;
        private readonly IRepository<Ninio> repositorioNinio;
        private readonly IRepository<CentroE> repositorioCentroE;
        private readonly IRepository<Cuenta> repositorioCuenta;
        public IContainerRepository repository;
        public IFormFile FotoNinio { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        [BindProperty]
        public Tutor Tutor { get; set; }
        [BindProperty]
        public Ninio Ninio { get; set; }
        [BindProperty]
        public CentroE CentroE { get; set; }
        public int NinioNuevo { get; set; }
        [BindProperty]
        public Cuenta Cuenta { get; set; }
        public int TutorNuevo { get; set; }
        public int cont;

        public AgregarNinioModel(IContainerRepository repository, IRepository<Tutor> repositorioTutor, IRepository<Ninio> repositorioNinio, IRepository<CentroE> repositorioCentroE, IRepository<Cuenta> repositorioCuenta, IWebHostEnvironment hostEnvironment)
        {
            this.repositorioTutor = repositorioTutor;
            this.repositorioNinio = repositorioNinio;
            this.repositorioCentroE = repositorioCentroE;
            this.repositorioCuenta = repositorioCuenta;
            this.repository = repository;
            this.HostEnvironment = hostEnvironment;

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
            //var id = Repository.Insert(workshop);
            Tutor.Cuenta = Cuenta;
            repositorioCuenta.Insert(Cuenta);
            TutorNuevo = repositorioTutor.Insert(Tutor);
            Ninio.TutorID = Tutor.Id;
            repositorioCentroE.Insert(CentroE);
            Ninio.CentroE = CentroE;
            NinioNuevo = repositorioNinio.Insert(Ninio);


            cont = repository.InicioSesion(Cuenta);
            return Redirect("/SesionDetails/?Id=" + cont);

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
