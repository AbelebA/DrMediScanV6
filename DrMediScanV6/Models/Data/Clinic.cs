namespace DrMediScanV6.Models.Data
{
    public class Clinic
    {
        public int Id { get; set; }
        public string ClinicName { get; set; }

        public DateTime AvailableDate { get; set; }

        public double AverageRate { get; set; }

        public bool IfAvailable { get; set; }

    }
}
