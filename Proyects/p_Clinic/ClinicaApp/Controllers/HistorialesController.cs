using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicaApp.Models;

namespace ClinicaApp.Controllers
{
    public class HistorialesController : Controller
    {
        private readonly ClinicaContext _context;

        public HistorialesController(ClinicaContext context)
        {
            _context = context;
        }

        // GET: Historiales
        public async Task<IActionResult> Index()
        {
            var clinicaContext = _context.Historiales.Include(h => h.Doctor).Include(h => h.Paciente);
            return View(await clinicaContext.ToListAsync());
        }

        // GET: Historiales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialClinico = await _context.Historiales
                .Include(h => h.Doctor)
                .Include(h => h.Paciente)
                .FirstOrDefaultAsync(m => m.HistorialClinicoId == id);
            if (historialClinico == null)
            {
                return NotFound();
            }

            return View(historialClinico);
        }

        // GET: Historiales/Create
        public IActionResult Create()
        {
            ViewData["DoctorId"] = new SelectList(_context.Doctores, "DoctorId", "Nombre");
            ViewData["PacienteId"] = new SelectList(_context.Pacientes, "PacienteId", "Nombre");
            return View();
        }

        // POST: Historiales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HistorialClinicoId,PacienteId,DoctorId,Diagnostico,Estado,FechaCreacion")] HistorialClinico historialClinico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(historialClinico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctores, "DoctorId", "Nombre", historialClinico.DoctorId);
            ViewData["PacienteId"] = new SelectList(_context.Pacientes, "PacienteId", "Nombre", historialClinico.PacienteId);
            return View(historialClinico);
        }

        // GET: Historiales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialClinico = await _context.Historiales.FindAsync(id);
            if (historialClinico == null)
            {
                return NotFound();
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctores, "DoctorId", "Nombre", historialClinico.DoctorId);
            ViewData["PacienteId"] = new SelectList(_context.Pacientes, "PacienteId", "Nombre", historialClinico.PacienteId);
            return View(historialClinico);
        }

        // POST: Historiales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HistorialClinicoId,PacienteId,DoctorId,Diagnostico,Estado,FechaCreacion")] HistorialClinico historialClinico)
        {
            if (id != historialClinico.HistorialClinicoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historialClinico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistorialClinicoExists(historialClinico.HistorialClinicoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctores, "DoctorId", "Nombre", historialClinico.DoctorId);
            ViewData["PacienteId"] = new SelectList(_context.Pacientes, "PacienteId", "Nombre", historialClinico.PacienteId);
            return View(historialClinico);
        }

        // GET: Historiales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialClinico = await _context.Historiales
                .Include(h => h.Doctor)
                .Include(h => h.Paciente)
                .FirstOrDefaultAsync(m => m.HistorialClinicoId == id);
            if (historialClinico == null)
            {
                return NotFound();
            }

            return View(historialClinico);
        }

        // POST: Historiales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var historialClinico = await _context.Historiales.FindAsync(id);
            if (historialClinico != null)
            {
                _context.Historiales.Remove(historialClinico);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistorialClinicoExists(int id)
        {
            return _context.Historiales.Any(e => e.HistorialClinicoId == id);
        }
    }
}
