using DrMediScanV6.Models.ViewModels;

namespace DrMediScanV6.Models.ViewModels
{
    public class BookAppointment
    {
        public List<SelectedClinic> Clinics { get; set; }
        public Patient PatientDetails { get; set; }
    }
}
