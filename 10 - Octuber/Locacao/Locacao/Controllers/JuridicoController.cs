using Microsoft.AspNetCore.Mvc;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Controllers
{
    public class JuridicoController : Controller
    {

        readonly private ApplicationDBContext _db;
        public JuridicoController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<JuridicoModel> juridicos = _db.Juridicos;
            return View(juridicos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(JuridicoModel juridicos) 
        {
            if (ModelState.IsValid) 
            {
                _db.Juridicos.Add(juridicos);
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

            JuridicoModel juridico = _db.Juridicos.FirstOrDefault(x => x.Id == id);

            if (juridico == null)
            {
                return NotFound();
            }

            return View(juridico);
        }

        [HttpPost]
        public IActionResult Editar(JuridicoModel juridico)
        {

            if (ModelState.IsValid)
            {
                _db.Juridicos.Update(juridico);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(juridico);

        }

        [HttpPost]
        public IActionResult Excluir(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            JuridicoModel juridico = _db.Juridicos.FirstOrDefault(x => x.Id == id);

            if (juridico == null)
            {
                return NotFound();
            }

            return View(juridico);
        }

        [HttpPost]
        public IActionResult Excluir(JuridicoModel juridico)
        {

            if (juridico == null)
            {
                return NotFound();
            }

            _db.Juridicos.Remove(juridico);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }

    }
}
