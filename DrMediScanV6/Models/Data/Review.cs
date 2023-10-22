namespace DrMediScanV5.Models.Data
{
    public class Review
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public int AppointmentId { get; set; }

        public int ClincId { get; set; }

        public int Score { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
    }
}
