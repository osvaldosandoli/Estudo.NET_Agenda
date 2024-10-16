using AgendaDeContatos.Data;
using AgendaDeContatos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgendaDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AgendaContext _context;
        public IActionResult Index()
        {
            return View();
        }

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

       

        // Tela de Cadastro - GET
        public IActionResult CadastrarView()
        {
            return View();
        }

        // Tela de Cadastro - POST
        [HttpPost]
        public IActionResult Cadastrar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        // Tela de Listagem
        public IActionResult ListarView()
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);
        }

    }
}
