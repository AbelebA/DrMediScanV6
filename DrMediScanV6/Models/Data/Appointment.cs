namespace DrMediScanV6.Models.Data
{
    public class Appointment
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PatientFirstName { get; set; }

        public string PatientLastName { get; set; }

        public string PatientPhoneNo { get; set; }

        public int ClinicId { get; set; }

        public string ClinicName { get; set; }

        public DateTime AppointmentTime { get; set; }

        public bool IfCompleted { get; set; }

    }
}
