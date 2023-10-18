using Microsoft.AspNetCore.Mvc;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Controllers
{
    public class LocacaoController : Controller
    {

        readonly private ApplicationDBContext _db;
        public LocacaoController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<LocacaoModel> locacoes = _db.Locacoes;
            return View(locacoes);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(LocacaoModel locacoes) 
        {
            if (ModelState.IsValid) 
            {
                _db.Locacoes.Add(locacoes);
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

            LocacaoModel pedido = _db.Locacoes.FirstOrDefault(x => x.Id == id);

            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        [HttpPost]
        public IActionResult Editar(LocacaoModel pedido)
        {

            if (ModelState.IsValid)
            {
                _db.Locacoes.Update(pedido);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(pedido);

        }

        [HttpPost]
        public IActionResult Excluir(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            LocacaoModel pedido = _db.Locacoes.FirstOrDefault(x => x.Id == id);

            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        [HttpPost]
        public IActionResult Excluir(LocacaoModel pedido)
        {

            if (pedido == null)
            {
                return NotFound();
            }

            _db.Locacoes.Remove(pedido);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }

    }
}
