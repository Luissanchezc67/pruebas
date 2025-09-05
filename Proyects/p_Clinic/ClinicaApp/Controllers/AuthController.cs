using Microsoft.AspNetCore.Mvc;

using ClinicaApp.Models;
using System.Linq;

namespace ClinicaApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly ClinicaContext _context;

        public AuthController(ClinicaContext context)
        {
            _context = context;
        }

        // GET: /Auth/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Auth/Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.User
                .FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                // Guardamos datos en sesión
                HttpContext.Session.SetString("User", user.Email);
                HttpContext.Session.SetString("Rol", user.Rol);

                // Redirigir al panel de navegación
                return RedirectToAction("Privacy", "Home");
            }

            ViewBag.Error = "Usuario o contraseña incorrectos";
            return View();
        }

        // Cerrar sesión
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
