using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid.Helpers.Mail;
using SendGrid;
using DrMediScanV6.Services;
using System.Net.Mail;

namespace DrMediScanV5.Services
{
    public class EmailSender : IExtendedEmailSender
    {
        private readonly ILogger _logger;

        public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor,
                           ILogger<EmailSender> logger)
        {
            Options = optionsAccessor.Value;
            _logger = logger;
        }

        public AuthMessageSenderOptions Options { get; } //Set with Secret Manager.

        public async Task SendEmailAsync(string toEmail, string subject, string message)
        {
            if (string.IsNullOrEmpty(Options.SendGridKey))
            {
                throw new Exception("Null SendGridKey");
            }
            await Execute(Options.SendGridKey, subject, message, toEmail);
        }

        public async Task SendAppointmentConfirmationAsync(string toEmail, string subject, string message, byte[] attachmentData)
        {
            var client = new SendGridClient(Options.SendGridKey);
            var msg = new SendGridMessage
            {
                From = new EmailAddress("abelpan2022@gmail.com", "DrMediScan"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };

            // Adding attachment to the email
            var fileContent = Convert.ToBase64String(attachmentData);
            msg.AddAttachment("appointment-details.pdf", fileContent);

            msg.AddTo(new EmailAddress(toEmail));
            await client.SendEmailAsync(msg);
        }



        public async Task Execute(string apiKey, string subject, string message, string toEmail)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("abelpan2022@gmail.com", "DrMediScan New Account Confirmation"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(toEmail));

            // Disable click tracking.
            // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            msg.SetClickTracking(false, false);
            var response = await client.SendEmailAsync(msg);
            _logger.LogInformation(response.IsSuccessStatusCode
                                   ? $"Email to {toEmail} queued successfully!"
                                   : $"Failure Email to {toEmail}");
        }

        public async Task ExecuteWithAttachment(string apiKey, string subject, string message, string toEmail, byte[] attachmentData = null, string attachmentFilename = null)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("abelpan2022@gmail.com", "DrMediScan Confirmation"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(toEmail));

            if (attachmentData != null && !string.IsNullOrEmpty(attachmentFilename))
            {
                var fileContent = Convert.ToBase64String(attachmentData);
                msg.AddAttachment(attachmentFilename, fileContent);
            }

            // Disable click tracking.
            msg.SetClickTracking(false, false);

            var response = await client.SendEmailAsync(msg);
            _logger.LogInformation(response.IsSuccessStatusCode
                                       ? $"Email to {toEmail} queued successfully!"
                                       : $"Failure Email to {toEmail}");
        }

    }
}
