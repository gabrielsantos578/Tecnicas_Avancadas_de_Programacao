using Microsoft.AspNetCore.Mvc;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Controllers
{
    public class LocacaoCarroController : Controller
    {

        readonly private ApplicationDBContext _db;
        public LocacaoCarroController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<LocacaoCarroModel> locacaocarro = _db.LocacaoCarros;
            return View(locacaocarro);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(LocacaoCarroModel locacaocarro)
        {
            if (ModelState.IsValid)
            {
                _db.LocacaoCarros.Add(locacaocarro);
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

            LocacaoCarroModel juridico = _db.LocacaoCarros.FirstOrDefault(x => x.Id == id);

            if (juridico == null)
            {
                return NotFound();
            }

            return View(juridico);
        }

        [HttpPost]
        public IActionResult Editar(LocacaoCarroModel juridico)
        {

            if (ModelState.IsValid)
            {
                _db.LocacaoCarros.Update(juridico);
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

            LocacaoCarroModel juridico = _db.LocacaoCarros.FirstOrDefault(x => x.Id == id);

            if (juridico == null)
            {
                return NotFound();
            }

            return View(juridico);
        }

        [HttpPost]
        public IActionResult Excluir(LocacaoCarroModel juridico)
        {

            if (juridico == null)
            {
                return NotFound();
            }

            _db.LocacaoCarros.Remove(juridico);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }

    }
}
