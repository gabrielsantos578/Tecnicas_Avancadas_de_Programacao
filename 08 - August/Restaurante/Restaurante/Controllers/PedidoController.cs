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

        [HttpPost]
        public IActionResult Editar(int? id)
        {

            if (id == null || id == 0) 
            { 
                return NotFound(); 
            }

            PedidoModel pedido = _db.Pedidos.FirstOrDefault(x => x.Id == id);

            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        [HttpPost]
        public IActionResult Editar(PedidoModel pedido)
        {

            if (ModelState.IsValid)
            {
                _db.Pedidos.Update(pedido);
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

            PedidoModel pedido = _db.Pedidos.FirstOrDefault(x => x.Id == id);

            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        [HttpPost]
        public IActionResult Excluir(PedidoModel pedido)
        {

            if (pedido == null)
            {
                return NotFound();
            }

            _db.Pedidos.Remove(pedido);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }

    }
}
