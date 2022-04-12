# Projeyi Çalıştırmadan Önce Yapılması Gerekenler.

1. WebUI ve WebAPI katmanlarındaki appsetting.json içerisindeki connectionStringin değiştirilmesi.<br>
```csharp
"ConnectionStrings": { "defaultConnection": "Server=DESKTOP-CAP6I0L\\SQLEXPRESS; Database=BilgeHotelDB; Trusted_Connection=True" }
```
2. Common katmanındaki MailSender classının içinde bulunan “RegisterActivationMessage" ve “PasswordUpdateActivationMessage” metotlarındaki localhost un değiştirilnesi<br>
```csharp
        public static string RegisterActivationMessage(string uniqueKey, string controllerName, string actionName)
        {
            return $"Marhaba,\n\nÜyelik işleminizi onaylamak için lütfen linki tıklayın.\n\n https://localhost:44321/{controllerName}/{actionName}/" + uniqueKey+ "\n\nSaygılarımızla,\nBilge Hotel";
        }
        public static string PasswordUpdateActivationMessage(string uniqueKey, string controllerName, string actionName)
        {
            return $"Marhaba,\n\nŞifre yenileme işleminizi onaylamak için lütfen linki tıklayın.\n\n https://localhost:44321/{controllerName}/{actionName}/" + uniqueKey + "\n\nSaygılarımızla,\nBilge Hotel";
        }
```
3. WebAPI katmanında Utilities klasöründeki MappingProfile classında Guest entitysinden GuestListModel ViewModeline mapleme işleminde kullanılan localhost un değiştirilmesi<br>
```csharp
            CreateMap<Guest, GuestListModel>()
                .ForMember(x => x.IdCardBackSideImage, w => w.MapFrom(x => "https://localhost:44321" + x.IdCardBackSideImage))
                .ForMember(x => x.IdCardFrontSideImage, w => w.MapFrom(x => "https://localhost:44321" + x.IdCardFrontSideImage));
```
4. WebUI katmanında Administrator aresında Home Controllerındeki Index View içerisindeki javascript ajax içinde bulunan localhost un değiştirilmesi<br>
```csharp
$(document).ready(function () {
            $.ajax({
                type: 'Get',
                url: 'https://localhost:44321/Administrator/Home/GetCurrencyRate',
```
5. WebUI katmanında Contact Controllerının Index actionındaki mesaj gönderiminde mesajı karşılayacak mail adresinin değiştirilmesi.<br>
```csharp
var mailResult = MailSender.SendMail("arlanoglumustafa@hotmail.com", "Müşteri İletişim", message, setting);
```
6. PackageManager Console üzerinde "update-database -Project DataAccess" komutu ile veritabanının oluşturulması.<br>
7. Veritabanındaki setting tablosunda smtp için gerekli mail bilgilerinin değiştirilmesi<br>
