using DrMediScanV6.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DrMediScanV6.Models.ViewModels;
using DrMediScanV6.Models.Data;
using Microsoft.AspNetCore.Identity.UI.Services;
using DinkToPdf;
using DinkToPdf.Contracts;
using System.IO;

namespace DrMediScanV6.Controllers
{
    public class BookAppointmentController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IExtendedEmailSender _emailSender;
        private readonly SynchronizedConverter _convert;


        public BookAppointmentController(ApplicationDbContext context, IExtendedEmailSender emailSender, SynchronizedConverter convert)
        {
            _context = context;
            _emailSender = emailSender;
            _convert = convert;
        }

        public IActionResult ClinicChoose()
        {
            var viewModel = new BookAppointment
            {
                Clinics = GetAvailableClinics(),
                PatientDetails = new Patient()
            };
            return View(viewModel);
        }

        private List<SelectedClinic> GetAvailableClinics()
        {
            DateTime currentTime = DateTime.Now;

            return _context.Clinic
                   .Where(c => c.IfAvailable && c.AvailableDate > currentTime)
                   .Select(c => new SelectedClinic
                   {
                       ClinicId = c.Id,
                       ClinicName = c.ClinicName,
                       AvailableDate = c.AvailableDate,
                       AverageRate = c.AverageRate
                   }).ToList();
        }

        [HttpPost]
        public async Task<IActionResult> ClinicChoose(BookAppointment viewModel, int ClinicSelection)
        {
            if (ModelState.IsValid)
            {
                var selectedClinic = viewModel.Clinics.FirstOrDefault(c => c.ClinicId == ClinicSelection);
                if (selectedClinic == null)
                {
                    ModelState.AddModelError(string.Empty, "Please select a clinic.");
                    viewModel.Clinics = GetAvailableClinics();
                    return View(viewModel);
                }

                bool isSuccess = await SaveAppointmentData(selectedClinic, viewModel.PatientDetails);
                if (!isSuccess)
                {
                    viewModel.Clinics = GetAvailableClinics();
                    return View(viewModel);
                }
                return RedirectToAction("SuccessBook");
            }
            else
            {
                viewModel.Clinics = GetAvailableClinics();
                return View(viewModel);
            }
        }


        private async Task<bool> SaveAppointmentData(SelectedClinic selectedClinic, Patient patient)
        {
            if (selectedClinic == null || patient == null)
            {
                throw new ArgumentNullException("Both clinic and patient must be provided.");
                //return false;
            }

            var clinicToMarkUnavailable = _context.Clinic.FirstOrDefault(c => c.Id == selectedClinic.ClinicId);
            if (clinicToMarkUnavailable != null)
            {
                clinicToMarkUnavailable.IfAvailable = false;
            }

            // Create a new appointment instance
            var appointment = new Appointment
            {
                UserName = User.Identity.Name,
                PatientFirstName = patient.FirstName,
                PatientLastName = patient.LastName,
                PatientPhoneNo = patient.PhoneNo,
                ClinicId = selectedClinic.ClinicId,
                ClinicName = selectedClinic.ClinicName,
                AppointmentTime = selectedClinic.AvailableDate,
                IfCompleted = false
            };

            try
            {
                _context.Appointment.Add(appointment);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Handle any database errors
                // You can decide how to handle this exception, whether to log it or re-throw it
                throw new InvalidOperationException("An error occurred while saving the appointment.", ex);
            }

            var appointmentDetails = _context.Appointment.FirstOrDefault(a => a.ClinicId == selectedClinic.ClinicId && a.UserName == User.Identity.Name);
            byte[] pdfData = GenerateAppointmentPdf(appointmentDetails);

            string emailSubject = "Appointment Confirmation";
            string emailMessage = "Thank you for booking an appointment! Please find attached the details.";

            await _emailSender.SendAppointmentConfirmationAsync(User.Identity.Name, emailSubject, emailMessage, pdfData);

            return true;
        }

        private byte[] GenerateAppointmentPdf(Appointment appointment)
        {
            // Initialize DinkToPdf converter
            //var converter = new SynchronizedConverter(new PdfTools());

            // Define the content of the PDF
            var content = $@"
                <html>
                    <head></head>
                    <body>
                        <h1>Appointment Confirmation</h1>
                        <p><strong>Clinic Name:</strong> {appointment.ClinicName}</p>
                        <p><strong>Appointment Time:</strong> {appointment.AppointmentTime}</p>
                        <p><strong>Patient Name:</strong> {appointment.PatientFirstName} {appointment.PatientLastName}</p>
                        <p><strong>Patient Phone No:</strong> {appointment.PatientPhoneNo}</p>
                        <p><strong>Username:</strong> {appointment.UserName}</p>
                    </body>
                </html>";

            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
            ColorMode = ColorMode.Color,
            Orientation = Orientation.Portrait,
            PaperSize = PaperKind.A4
        },
                Objects = {
            new ObjectSettings() {
                PagesCount = true,
                HtmlContent = content,
                WebSettings = { DefaultEncoding = "utf-8" }
            }
        }
            };

            byte[] pdfData = _convert.Convert(doc);
            return pdfData;
        }

        public IActionResult SuccessBook()
        {
            return View();
        }

    }
}
