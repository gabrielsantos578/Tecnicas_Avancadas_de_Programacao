using Microsoft.AspNetCore.Mvc;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Controllers
{
    public class CarroController : Controller
    {

        readonly private ApplicationDBContext _db;
        public CarroController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<CarroModel> carros = _db.Carros;
            return View(carros);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(CarroModel carros) 
        {
            if (ModelState.IsValid) 
            {
                _db.Carros.Add(carros);
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

            CarroModel carro = _db.Carros.FirstOrDefault(x => x.Id == id);

            if (carro == null)
            {
                return NotFound();
            }

            return View(carro);
        }

        [HttpPost]
        public IActionResult Editar(CarroModel carro)
        {

            if (ModelState.IsValid)
            {
                _db.Carros.Update(carro);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(carro);

        }

        [HttpPost]
        public IActionResult Excluir(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            CarroModel carro = _db.Carros.FirstOrDefault(x => x.Id == id);

            if (carro == null)
            {
                return NotFound();
            }

            return View(carro);
        }

        [HttpPost]
        public IActionResult Excluir(CarroModel carro)
        {

            if (carro == null)
            {
                return NotFound();
            }

            _db.Carros.Remove(carro);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }

    }
}
