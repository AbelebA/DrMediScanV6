namespace DrMediScanV6.Models.ViewModels
{
    public class UserReview
    {
        public int AppointmentId { get; set; }
        public string UserName { get; set; }
        public string ClinicName { get; set; }
        public string Comment { get; set; }
        public int Score { get; set; }
    }
}
