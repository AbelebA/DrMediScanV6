using Microsoft.AspNetCore.Identity.UI.Services;

public interface IExtendedEmailSender : IEmailSender
{
    Task SendEmailAsync(string email, string subject, string htmlMessage);
    Task SendAppointmentConfirmationAsync(string toEmail, string subject, string message, byte[] attachmentData);
}
