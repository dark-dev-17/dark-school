using Forms.Models.Libro;
using Microsoft.AspNetCore.Mvc;

namespace Forms.Controllers
{
    public class LibroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            List<LibroCreateModel> lista =  new List<LibroCreateModel>();

            lista.Add(new LibroCreateModel
            {
                Nombre = "libro 1"
            });
            lista.Add(new LibroCreateModel
            {
                Nombre = "libro 2"
            });
            lista.Add(new LibroCreateModel
            {
                Nombre = "libro 3"
            });
            return View(new LibroRegisterModel
            {
                LibrosToCreate = lista

            });
        }
        [HttpPost]
        public IActionResult Registrar(LibroRegisterModel lista)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(lista);
            //}
            return View(lista);
        }
        //[HttpPost]
        //public IActionResult Registrar(List<LibroCreateModel> lista)
        //{
        //    return View(lista);
        //}
    }
}
