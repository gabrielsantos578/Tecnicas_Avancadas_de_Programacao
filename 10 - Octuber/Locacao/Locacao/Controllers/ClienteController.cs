using Microsoft.AspNetCore.Mvc;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Controllers
{
    public class ClienteController : Controller
    {

        readonly private ApplicationDBContext _db;
        public ClienteController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ClienteModel> clientes = _db.Clientes;
            return View(clientes);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(ClienteModel clientes) 
        {
            if (ModelState.IsValid) 
            {
                _db.Clientes.Add(clientes);
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

            ClienteModel cliente = _db.Clientes.FirstOrDefault(x => x.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(ClienteModel cliente)
        {

            if (ModelState.IsValid)
            {
                _db.Clientes.Update(cliente);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(cliente);

        }

        [HttpPost]
        public IActionResult Excluir(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            ClienteModel cliente = _db.Clientes.FirstOrDefault(x => x.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Excluir(ClienteModel cliente)
        {

            if (cliente == null)
            {
                return NotFound();
            }

            _db.Clientes.Remove(cliente);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }

    }
}
