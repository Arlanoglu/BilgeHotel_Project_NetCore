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
        /// <returns>Geriye string tipte bir mesage dönecektir. SendMail metodunun message parametresine gönderilir.</returns>
        public static string RegisterActivationMessage(string uniqueKey, string controllerName, string actionName)
        {
            return $"Marhaba,\n\nÜyelik işleminizi onaylamak için lütfen linki tıklayın.\n\n https://localhost:44321/{controllerName}/{actionName}/" + uniqueKey+ "\n\nSaygılarımızla,\nBilge Hotel";
        }
        public static string PasswordUpdateActivationMessage(string uniqueKey, string controllerName, string actionName)
        {
            return $"Marhaba,\n\nŞifre yenileme işleminizi onaylamak için lütfen linki tıklayın.\n\n https://localhost:44321/{controllerName}/{actionName}/" + uniqueKey + "\n\nSaygılarımızla,\nBilge Hotel";
        }

        /// <summary>
        /// Rezervasyon tamamlama işleminde gönderilecek maile message oluşturmak için kullanılacak metotdur.
        /// </summary>
        /// <param name="reservationId">Kullanıcının oluşturduğu rezervasyona ait id bilgisini içerir.</param>
        /// <param name="reservationDate">Rezervasyon oluşturma tarihi.</param>
        /// <param name="checkInDate">Rezervasyonun giriş tarihi.</param>
        /// <param name="checkOutDate">Rezervasyonun çıkış tarihi.</param>
        /// <returns>Geriye string tipte bir mesage dönecektir. SendMail metodunun message parametresine gönderilir.</returns>
        public static string ReservationCompleteMessage(int reservationId, DateTime reservationDate ,DateTime checkInDate, DateTime checkOutDate)
        {
            return $"Marhaba,\n\nBLGHTLW-{reservationId} rezervasyon numaralı, giriş tarihi {checkInDate.Date.ToShortDateString()}, çıkış tarihi {checkOutDate.Date.ToShortDateString()} olan rezervasyon talebiniz tarafımıza ulaşmış, {reservationDate} tarihinde rezervasyonunuz oluşturulmuştur.\n\nRezervasyonunuz ile ilgili tüm detayları web sayfanızdaki Rezervasyonlarım bölümünden görüntüleyebilirsiniz.\n\nRezervasyon tarihinize 2 gün kala ödeme işlemi gerçekleştirilmediği takdirde rezervasyonunuz iptal edilecektir.\n\nBizi tercih ettiğiniz için teşekkür eder, iyi günler dileriz.\n\nSaygılarımızla,\nBilge Hotel";
        }
        /// <summary>
        /// Resepsiyon için rezervasyon tamamlama işleminde gönderilecek maile message oluşturmak için kullanılacak metotdur.
        /// </summary>
        /// <param name="reservationId">Kullanıcının oluşturduğu rezervasyona ait id bilgisini içerir.</param>
        /// <param name="reservationDate">Rezervasyon oluşturma tarihi.</param>
        /// <param name="checkInDate">Rezervasyonun giriş tarihi.</param>
        /// <param name="checkOutDate">Rezervasyonun çıkış tarihi.</param>
        /// <returns>Geriye string tipte bir mesage dönecektir. SendMail metodunun message parametresine gönderilir.</returns>
        public static string ReceptionReservationCompleteMessage(int reservationId, DateTime reservationDate, DateTime checkInDate, DateTime checkOutDate)
        {
            return $"Marhaba,\n\nBLGHTLR-{reservationId} rezervasyon numaralı, giriş tarihi {checkInDate.Date.ToShortDateString()}, çıkış tarihi {checkOutDate.Date.ToShortDateString()} olan rezervasyon talebiniz tarafımıza ulaşmış, {reservationDate} tarihinde rezervasyonunuz oluşturulmuştur.\n\nRezervasyon tarihinize 2 gün kala ödeme işlemi gerçekleştirilmediği takdirde rezervasyonunuz iptal edilecektir.\n\nBizi tercih ettiğiniz için teşekkür eder, iyi günler dileriz.\n\nSaygılarımızla,\nBilge Hotel";
        }

        /// <summary>
        /// Web rezervasyon iptal işleminde gönderilecek maile message oluşturmak için kullanılacak metotdur.
        /// </summary>
        /// <param name="reservationId">Kullanıcının iptal ettiği rezervasyona ait id bilgisini içerir.</param>
        /// <param name="checkInDate">Rezervasyonun giriş tarihi.</param>
        /// <param name="checkOutDate">Rezervasyonun çıkış tarihi.</param>
        /// <returns>Geriye string tipte bir mesage dönecektir. SendMail metodunun message parametresine gönderilir.</returns>
        public static string CancelReservationMessage(int reservationId, DateTime checkInDate, DateTime checkOutDate)
        {
            return $"Marhaba,\n\nBLGHTLW-{reservationId} rezervasyon numaralı, giriş tarihi {checkInDate.Date.ToShortDateString()}, çıkış tarihi {checkOutDate.Date.ToShortDateString()} olan rezervasyon iptal talebiniz tarafımıza ulaşmış, Rezervasyonunuz iptal edilmiştir.\n\nİptal edilen ve diğer aktif olan rezervasyonlarınız ile ilgili tüm detayları web sayfanızdaki Rezervasyonlarım bölümünden görüntüleyebilirsiniz.\n\nBizi tercih ettiğiniz için teşekkür eder, iyi günler dileriz.\n\nSaygılarımızla,\nBilge Hotel";
        }
        /// <summary>
        /// Reseptiyon rezervasyon iptal işleminde gönderilecek maile message oluşturmak için kullanılacak metotdur.
        /// </summary>
        /// <param name="reservationId">Kullanıcının iptal ettiği rezervasyona ait id bilgisini içerir.</param>
        /// <param name="checkInDate">Rezervasyonun giriş tarihi.</param>
        /// <param name="checkOutDate">Rezervasyonun çıkış tarihi.</param>
        /// <returns>Geriye string tipte bir mesage dönecektir. SendMail metodunun message parametresine gönderilir.</returns>
        public static string CancelReceptionReservationMessage(int reservationId, DateTime checkInDate, DateTime checkOutDate)
        {
            return $"Marhaba,\n\nBLGHTLR-{reservationId} rezervasyon numaralı, giriş tarihi {checkInDate.Date.ToShortDateString()}, çıkış tarihi {checkOutDate.Date.ToShortDateString()} olan rezervasyon iptal talebiniz tarafımıza ulaşmış, Rezervasyonunuz iptal edilmiştir.\n\nBilgilerinize sunar, iyi günler dileriz.\n\nSaygılarımızla,\nBilge Hotel";
        }
        /// <summary>
        /// Web rezervasyonda ödeme yapılmayan rezervasyonun iptal işleminde gönderilecek maile message oluşturmak için kullanılacak metotdur.
        /// </summary>
        /// <param name="reservationId">Kullanıcının iptal ettiği rezervasyona ait id bilgisini içerir.</param>
        /// <param name="checkInDate">Rezervasyonun giriş tarihi.</param>
        /// <param name="checkOutDate">Rezervasyonun çıkış tarihi.</param>
        /// <returns>Geriye string tipte bir mesage dönecektir. SendMail metodunun message parametresine gönderilir.</returns>
        public static string UnPaidCancelWebReservationMessage(int reservationId, DateTime checkInDate, DateTime checkOutDate)
        {
            return $"Marhaba,\n\nBLGHTLW-{reservationId} rezervasyon numaralı, giriş tarihi {checkOutDate.Date.ToShortDateString()}, çıkış tarihi {checkInDate.Date.ToShortDateString()} olan rezervasyonunuza dair ödeme süresi içerisinde herhangi bir ödeme yapılmadığı gözlemlenerek, rezervasyonunuz tarafımızca iptal edilmiştir.\n\nİptal edilen ve diğer aktif olan rezervasyonlarınız ile ilgili tüm detayları web sayfanızdaki Rezervasyonlarım bölümünden görüntüleyebilirsiniz.\n\nBizi tercih ettiğiniz için teşekkür eder, iyi günler dileriz.\n\nSaygılarımızla,\nBilge Hotel";
        }
        /// <summary>
        /// Resepsiyon rezervasyonda ödeme yapılmayan rezervasyonun iptal işleminde gönderilecek maile message oluşturmak için kullanılacak metotdur.
        /// </summary>
        /// <param name="reservationId">Kullanıcının iptal ettiği rezervasyona ait id bilgisini içerir.</param>
        /// <param name="checkInDate">Rezervasyonun giriş tarihi.</param>
        /// <param name="checkOutDate">Rezervasyonun çıkış tarihi.</param>
        /// <returns>Geriye string tipte bir mesage dönecektir. SendMail metodunun message parametresine gönderilir.</returns>
        public static string UnPaidCancelReceptionReservationMessage(int reservationId, DateTime checkInDate, DateTime checkOutDate)
        {
            return $"Marhaba,\n\nBLGHTLR-{reservationId} rezervasyon numaralı, giriş tarihi {checkOutDate.Date.ToShortDateString()}, çıkış tarihi {checkInDate.Date.ToShortDateString()} olan rezervasyonunuza dair ödeme süresi içerisinde herhangi bir ödeme yapılmadığı gözlemlenerek, rezervasyonunuz tarafımızca iptal edilmiştir.\n\nBilgilerinize sunar, iyi günler dileriz.\n\nSaygılarımızla,\nBilge Hotel";
        }
    }
}
