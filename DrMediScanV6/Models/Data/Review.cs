namespace DrMediScanV6.Models.Data
{
    public class Review
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public int AppointmentId { get; set; }

        public string ClinicName { get; set; }

        public string? Comment { get; set; }

        public double Score { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
    }
}
