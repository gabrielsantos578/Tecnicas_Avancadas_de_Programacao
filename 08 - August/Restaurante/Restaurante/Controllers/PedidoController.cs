using Microsoft.AspNetCore.Mvc;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Controllers
{
    public class PedidoController : Controller
    {

        readonly private ApplicationDBContext _db;
        public PedidoController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<PedidoModel> pedidos = _db.Pedidos;
            return View(pedidos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(PedidoModel pedidos) 
        {
            if (ModelState.IsValid) 
            {
                _db.Pedidos.Add(pedidos);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
