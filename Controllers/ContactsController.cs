using Microsoft.AspNetCore.Mvc;
using Empresa_Form_Contact.Models;
using System.Threading.Tasks;

namespace Empresa_Form_Contact.Controllers
{
    public class ContactsController : Controller
    {
        private readonly MueblescorpContext _context;

        public ContactsController(MueblescorpContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SubmitContactForm([Bind("Nombre,Correo,Mensaje")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                TempData["Message"] = "Contacto enviado con éxito";
                return RedirectToAction(nameof(Index));
            }
            return View("Index", contact);
        }
    }
}
