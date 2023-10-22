namespace DrMediScanV5.Models.Data
{
    public class Clinic
    {
        public int Id { get; set; }
        public string ClinicName { get; set; }

        public DateTime AvailableDate { get; set; }

        public int AverageRate { get; set; }

        public bool IfAvailable { get; set; }

    }
}
