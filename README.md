# Projeyi Çalıştırmadan Önce Yapılması Gerekenler.

1. WebUI ve WebAPI katmanlarındaki appsetting.json içerisindeki ConnectionStringin değiştirilmesi.<br>
```csharp
"ConnectionStrings": { "defaultConnection": "Server=DESKTOP-CAP6I0L\\SQLEXPRESS; Database=BilgeHotelDB; Trusted_Connection=True" }
```
2. WebUI katmanında Contact Controllerının Index actionındaki mesaj gönderiminde mesajı karşılayacak mail adresinin değiştirilmesi.<br>
```csharp
var mailResult = MailSender.SendMail("arlanoglumustafa@hotmail.com", "Müşteri İletişim", message, setting);
```
6. PackageManager Console üzerinde "update-database -Project DataAccess" komutu ile veritabanının oluşturulması.<br>
7. Veritabanındaki setting tablosunda smtp için gerekli mail bilgilerinin değiştirilmesi<br>

# Admin paneline giriş için kullanılabilecek hesaplar.
Müdür : <br>
Email : Ida_Ruecker@yahoo.com	Şifre : Ida.123<br><br>

Insan Kaynaklari : <br>
Email : Tina.Zieme@yahoo.com		Şifre : Tina.123<br><br>

Resepsiyon : <br>
Email : Adrian.Maggio@gmail.com	Şifre : Adrian.123<br><br>

Temizlik Görevlisi : <br>
Email : Eunice96@yahoo.com		Şifre : Eunice.123

