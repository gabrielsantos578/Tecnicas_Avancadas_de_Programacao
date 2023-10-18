using Microsoft.AspNetCore.Mvc;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Controllers
{
    public class FisicoController : Controller
    {

        readonly private ApplicationDBContext _db;
        public FisicoController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<FisicoModel> fisicos = _db.Fisicos;
            return View(fisicos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(FisicoModel fisicos) 
        {
            if (ModelState.IsValid) 
            {
                _db.Fisicos.Add(fisicos);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Editar(int? id)
        {

            if (id == null || id == 0) 
            { 
                return NotFound(); 
            }

            FisicoModel fisico = _db.Fisicos.FirstOrDefault(x => x.Id == id);

            if (fisico == null)
            {
                return NotFound();
            }

            return View(fisico);
        }

        [HttpPost]
        public IActionResult Editar(FisicoModel fisico)
        {

            if (ModelState.IsValid)
            {
                _db.Fisicos.Update(fisico);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(fisico);

        }

        [HttpPost]
        public IActionResult Excluir(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            FisicoModel fisico = _db.Fisicos.FirstOrDefault(x => x.Id == id);

            if (fisico == null)
            {
                return NotFound();
            }

            return View(fisico);
        }

        [HttpPost]
        public IActionResult Excluir(FisicoModel fisico)
        {

            if (fisico == null)
            {
                return NotFound();
            }

            _db.Fisicos.Remove(fisico);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }

    }
}
