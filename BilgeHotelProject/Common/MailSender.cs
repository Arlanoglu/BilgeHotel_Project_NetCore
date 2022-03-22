using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class MailSender
    {
        public static int SendMail(string email, string subject, string message, Setting setting)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(setting.SmtpEmail, "BILGEHOTEL");
                mailMessage.To.Add(email);
                mailMessage.Subject = subject;
                mailMessage.Body = message;

                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new NetworkCredential(setting.SmtpEmail, setting.SmtpPassword);
                smtp.EnableSsl = true;
                smtp.Port = setting.SmtpPort;
                smtp.Host = setting.SmtpHost;

                smtp.Send(mailMessage);

                return 1;
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                return 0;
            }
        }

        /// <summary>
        /// Register işleminde gönderilecek maile message oluşturmak için kullanılacak metotdur.
        /// Kullanılacak Bilgisayarda linkteki 44389 bölümü değiştirilmelidir.
        /// </summary>
        /// <param name="uniqueKey">Kullanıcıya Guid tipinde bir activasyon kodu oluşturup kullanıcının ActivationKey propertysine eklenecektir.</param>
        /// <param name="controllerName">Activasyon Linki tıklandığında yönlendirilecek Controller ismi.</param>
        /// <param name="actionName">Activasyon Linki tıklandığında yönlendirilecek Action ismi.</param>
        /// <returns>Geriye string tipte bir mesage dönecektir. SenMail metodunun message parametresine gönderilir.</returns>
        public static string RegisterActivationMessage(Guid uniqueKey, string controllerName, string actionName)
        {
            return $"Marhaba,\n\nÜyelik işleminizi onaylamak için lütfen linki tıklayın.\n\n https://localhost:44321/{controllerName}/{actionName}/" + uniqueKey+ "\n\nSaygılarımızla,\nBilge Hotel";
        }
    }
}
