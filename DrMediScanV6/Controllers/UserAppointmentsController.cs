using DrMediScanV6.Models.ViewModels;
using DrMediScanV6.Models.Data;
using Microsoft.AspNetCore.Mvc;
using DrMediScanV6.Data;

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
            var appointments = _context.Appointment
                               .Where(a => a.UserName == userName && !a.IfCompleted)
                               .ToList();

            bool hasCompletedAppointments = false;
            foreach (var appointment in appointments)
            {
                if (appointment.AppointmentTime < DateTime.Now && !appointment.IfCompleted)
                {
                    appointment.IfCompleted = true;
                    hasCompletedAppointments = true;
                }
            }

            if (hasCompletedAppointments)
            {
                _context.SaveChanges();
            }

            return View(appointments);
        }

        // Logic of Deleting Appointment
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

        public IActionResult HistoryAppointments()
        {
            var userName = User.Identity.Name;

            // find appointments whose IfCompleted is true
            var completedAppointments = _context.Appointment
                                                .Where(a => a.UserName == userName && a.IfCompleted)
                                                .ToList();
            return View(completedAppointments);
        }


        public IActionResult WriteReview(int id)
        {
            var appointment = _context.Appointment.Find(id);
            if (appointment == null)
            {
                return NotFound();
            }
            var viewModel = new UserReview
            {
                UserName = User.Identity.Name,
                AppointmentId = appointment.Id,
                ClinicName = appointment.ClinicName
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SubmitReview(UserReview viewModel)
        {
            if (ModelState.IsValid)
            {
                var review = new Review
                {
                    UserName = viewModel.UserName,
                    AppointmentId = viewModel.AppointmentId,
                    ClinicName = viewModel.ClinicName,
                    Comment = viewModel.Comment,
                    Score = viewModel.Score,
                    Created = DateTime.Now
                };
                _context.Review.Add(review);

                var appointment = await _context.Appointment.FindAsync(viewModel.AppointmentId);
                if (appointment != null)
                {
                    var clinicId = appointment.ClinicId;
                    var clinic = await _context.Clinic.FindAsync(clinicId);

                    if (clinic != null)
                    {
                        // Retrieve all reviews for this clinic
                        var reviews = _context.Review.Where(r => r.ClinicName == clinic.ClinicName).ToList();
                        var totalScore = reviews.Sum(r => r.Score) + viewModel.Score;

                        // Calculate the new average rate
                        var averageRate = totalScore / (reviews.Count + 1);

                        clinic.AverageRate = averageRate;
                        _context.Update(clinic);
                    }
                }
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Review submitted successfully!";
                return RedirectToAction("HistoryAppointments");
            }
            return View("WriteReview", viewModel);
        }

    }
}
