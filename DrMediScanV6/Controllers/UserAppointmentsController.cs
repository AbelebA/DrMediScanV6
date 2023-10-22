using DrMediScanV6.Data;
using Microsoft.AspNetCore.Mvc;

namespace DrMediScanV6.Controllers
{
    public class UserAppointmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserAppointmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var userName = User.Identity.Name;
            var appointments = _context.Appointment.Where(a => a.UserName == userName).ToList();
            return View(appointments);
        }

        [HttpPost]
        public async Task<IActionResult> Index(int id)
        {
            try
            {
                var appointment = await _context.Appointment.FindAsync(id);
                if (appointment != null)
                {
                    var clinic = await _context.Clinic.FindAsync(appointment.ClinicId);

                    if (clinic != null)
                    {
                        clinic.IfAvailable = true;
                        _context.Update(clinic);
                    }
                    _context.Appointment.Remove(appointment);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Delete Successfully!";
                }
                else
                {
                    TempData["ErrorMessage"] = "Appointment not found!";
                }
            }
            catch (Exception ex)
            {

                TempData["ErrorMessage"] = "An error occurred while deleting the appointment.";
            }

            return RedirectToAction("Index");
        }
    }
}
