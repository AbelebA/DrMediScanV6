namespace DrMediScanV6.Models.ViewModels
{
    public class SelectedClinic
    {
        public bool IsSelected { get; set; }
        public int ClinicId { get; set; }
        public string ClinicName { get; set; }
        public DateTime AvailableDate { get; set; }
        public int AverageRate { get; set; }
        public bool IfAvailable { get; set; }
    }
}
