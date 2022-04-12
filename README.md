# NOT
Bu proje, sertifikasyon programı için kurgulanan bitirme projesi kapsamında tamamen bilgiyi pekiştirmek ve yeni bilgiler, deneyimler edinmek amacıyla tarafımca yazılmış bir projedir. Bu sebeple geliştirilebilecek, daha temiz ve kullanışlı yazılabilecek alanları da bulunmaktadır.
# Projeyi Çalıştırmadan Önce Yapılması Gerekenler.

1. WebUI ve WebAPI katmanlarındaki appsetting.json içerisindeki ConnectionStringin değiştirilmesi.<br>
```csharp
"ConnectionStrings": { "defaultConnection": "Server=DESKTOP-CAP6I0L\\SQLEXPRESS; Database=BilgeHotelDB; Trusted_Connection=True" }
```
2. WebUI katmanında Contact Controllerının Index actionındaki mesaj gönderiminde mesajı karşılayacak mail adresinin değiştirilmesi.<br>
```csharp
var mailResult = MailSender.SendMail("arlanoglumustafa@hotmail.com", "Müşteri İletişim", message, setting);
```
6. PackageManager Console üzerinde ```update-database -Project DataAccess``` komutu ile veritabanının oluşturulması.<br>
7. Veritabanındaki setting tablosunda smtp için gerekli mail bilgilerinin değiştirilmesi (Üyelik ve rezervasyon işlemlerinde gönderilecek mail işlemleri için)<br>

# Admin paneline giriş için kullanılabilecek hesaplar.
Müdür : <br>
Email : Ida_Ruecker@yahoo.com	Şifre : Ida.123<br>

Insan Kaynaklari : <br>
Email : Tina.Zieme@yahoo.com		Şifre : Tina.123<br>

Resepsiyon : <br>
Email : Adrian.Maggio@gmail.com	Şifre : Adrian.123<br>

Temizlik Görevlisi : <br>
Email : Eunice96@yahoo.com		Şifre : Eunice.123

# Senaryo - Amaç ve Tanım
Bilge Hotel, Kemer bölgesinde hizmet veren 5 yıldızlı bir oteldir. <br>
Otelde 7 resepsiyon görevlisi, 11 temizlik görevlisi, 11 aşçı, 13 garson, 1 elektrikçi, 1 bilgi işlem sorumlusu,  bulunmaktadır.<br>
Bilge Hotel tarafından istenen; otelin tanıtımını yapan, rezervasyon yapılabilen bir web sayfası ve bununla birlikte tüm ihitiyaçları karşılayacak ve koordineli çalışacak bir yönetim paneli uygulamasının yazılması.<br>

# Projede yapılması istenen maddeler
### 1.	Günlük kurların görüntülenmesi
###	2. Yönetim modülü - Rezervasyon 
-	Rezervasyonların görüntülenmesi (Web sitesi ve resepsiyon tarafından yapılan rezervasyonlar)
-	Yeni rezervasyon oluşturulması ve rezervasyon işleminde boş odaları manuel atama değil sistemin otomatik olarak ataması.
-	Müşteriler günün herhangi bir saati giriş yapabilir ama 14 olarak kayıt edilir. Çıkış ise 10:00 da gerçekleşir. 
-	Müşteri odadan çıktığında odanın kirli olduğu bilgisi kayıt edilip temizlik görevlisi tarafından temizliğe alınabilmesi.
-	Resepsiyon görevlisinin odaları takip edip hiçbir çakışma olmadan rezervasyon yapabilmesi.
-	Resepsiyon görevlisi müşteriye odayı rezerve ederken hangi özelliklere sahip olduğunu açık bi şekilde görerek listeleyebilmesi.
-	Odanın tipine ve müşterinin seçtiği pakete göre gün sayısıyla birlikte fiyat hesaplayabilmesi.
-	Web sitesi ve resepsiyondan yapılan rezervasyonların koordineli çalışması ve çakışmaların yaşanmaması.
-	Her şey dahil pakete sahip olmayan müşterilerin çıkışlarını yaparken ekstra harcamaları varsa bunun hesabının sistem tarafından yapılabilmesi.

### 3.	Yönetim modülü - Admin/Yönetici
-	Yöneticiler haricinde giriş yapılamaması
-	Rezevasyon modülünün tüm işlemlerinin takibinin yapılabilmesi
-	Web sitesine müdahale (Fiyatlarda değişiklik gibi) edilebilmesi
-	Personel Kayıtları (vardiya saatleri, ücretler) ve takibinin yapılabilmesi
-	Vardiya saatileri ile çalışanların vardiyalarının görüntülenmesi.
-	Çalışanların detaylarında saat bazında aldığı ücretin tanımlanması.
-	Yöneticilerin aylık, çalışanların saat bazında ücret alması ve maaş hesabının bu bilgiye nazaran yapılması.
-	Çalışanın çalışma durumuna göre maaşının hesaplanması.
-	Ek mesai yapıldığında programa kayıdının yapılıp çalışan maaşına eklenmesi.
-	Odada bakım ve düzenleme yapılacak ise odayı dolu değil  tadilat işaretlenebilmesi.
-	Hangi odada hangi müşterinin olduğu, kimin rezervasyon yaptırdığı ve müşterinin daha önce otele gelip gelmediği gibi bilgilerinin görüntülenebilmesi.
-	Günlük kalan müşterilerin kimlik bilgilerinin web servisler ile valiliğe raporlanması.

### 4.	Web modülü
-	Otelin tanıtımı
-	Otelin olanaklarının görüntülenmesi.
-	İnternet üzerinden rezervasyon imkanı.
-	Oda özelliklerinin görüntülenebilmesi.
-	Kullanıcı kaydının yapılabilmesi(Üyelik işlemi).
-	Internet üzerinden yapılan rezervasyonlara özel indirimler<br>
    - 1 ay önce yapılan herşey dahil paket rezervasyonlara %18<br>
    - 1 ay önce yapılan tam pansiyon paket rezervasyonlara %16<br>
    - 3 ay önce yapılan tüm rezervasyonlara %23<br>

# Kullanılan Teknolojiler
- Asp.Net Core 5 MVC
- WebAPI Restful
- NTier Architecture
- C#
- JQuery Ajax
- Entity Framework
    - Code First
- MSSQL Server
- Bootstrap 4
- HTML5
- Bogus Framework
- AutoMapper Framework

# Kullanılan Şablonlar
> Web arayüzü şablonu [Hotel-Template](https://github.com/sujata-te/Hotel-Template). <br>
> Admin Paneli arayüzü şablonu [AdminLTE v3.2.0](https://github.com/ColorlibHQ/AdminLTE/releases).
