using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Entities.Enum;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public static class FakeData
    {
        public static void Seed(this ModelBuilder builder)
        {
            //Site
            #region Aboutus
            builder.Entity<Aboutus>().HasData(
                new Aboutus {
                    ID = 1,
                    PictureUrl= "/img/aboutus-img.jpg",
                    Title = "Bilge Hotel, Kalite ve Konforun Adresi",
                    Paragraph1 = "Kemer’in tarihi ve kültürel merkezlerinin kesişim noktasında yer alan, şehrin ilk 5 yıldızlı konaklama tesisi unvanına sahip Bilge Hotel, 35 yıllık deneyimi ile alanının en iyisi olmaya devam ediyor.",
                    Paragraph2 = "Bilge Hotel, Osmanlı sarayları ve Fransız mimarisinden esinlenilerek özenle tasarlanmış yeni konsepti kapsamında; birbirinden farklı şekilde dekore edilmiş lüks oda ve süitleri, Türk ve dünya mutfağının seçkin lezzetlerini servis eden restoranları, A’dan Z’ye yenilenmiş SPA tesisiyle misafirlerine en konforlu konaklama deneyimini sunuyor.",
                    Paragraph3 = "Bilge Hotel iş toplantıları, kutlamalar ve farklı özel etkinlikler için 1000 kişilik kapasiteye ve eksiksiz teknik donanıma sahip salonlarıyla bir şehir otelinin ötesine geçerek kişiye özel lüks hizmetler sunuyor.",
                    Paragraph4 = "Kemer şehir merkezinde yer alan Bilge Otel, alışveriş merkezlerine, Atatürk Kongre ve Kültür Merkezi’ne ve toplu taşıma duraklarına yürüyüş mesafesindedir.",
                    Paragraph5 = "Bilge Hotel Güvenli Turizm Sertifikası, ISO 22000 Gıda Güvenliği Yönetim Sistemi Belgesi, Sıfır Atık Belgesi ve Turuncu Bayrak sahibidir." }
                );
            #endregion

            #region Picture
            builder.Entity<Picture>().HasData(
                new Picture { ID = 1, PictureName = "Görsel1", AboutusID=1, PictureUrl= "/img/gallery/room-single.jpg"},
                new Picture { ID = 2, PictureName = "Görsel2", AboutusID=1, PictureUrl= "/img/gallery/room-double.jpg" },
                new Picture { ID = 3, PictureName = "Görsel3", AboutusID=1, PictureUrl= "/img/gallery/room-double-superrior.jpg" },
                new Picture { ID = 4, PictureName = "Görsel4", AboutusID=1, PictureUrl= "/img/gallery/room-triple.jpg" },
                new Picture { ID = 5, PictureName = "Görsel5", AboutusID=1, PictureUrl= "/img/gallery/room-triple-superrior.jpg" },
                new Picture { ID = 6, PictureName = "Görsel6", AboutusID=1, PictureUrl= "/img/gallery/room-family.jpg" },
                new Picture { ID = 7, PictureName = "Görsel7", AboutusID = 1, PictureUrl = "/img/gallery/room-presidential-suite.jpg" }
                );
            #endregion            

            #region Contact
            var fakeContact = new Faker<Contact>()
                .RuleFor(x => x.Adress, x => x.Address.FullAddress())
                .RuleFor(x => x.Phone1, x => x.Phone.PhoneNumber("05454526235"))
                .RuleFor(x => x.Fax, x => x.Phone.PhoneNumber("05454526235"))
                .RuleFor(x => x.Email, x => x.Person.Email);
            Contact contact = fakeContact;
            contact.ID = 1;
            contact.Facebook = "https://www.facebook.com/bilgehotel";
            contact.Instagram = "https://www.instagram.com/bilgehotel";
            contact.Twitter = "https://www.twitter.com/bilgehotel";

            builder.Entity<Contact>().HasData(contact);
            #endregion

            #region HomePage
            builder.Entity<HomePage>().HasData(
                new HomePage {
                    ID = 1,
                    PictureUrl= "/img/homepage-img.jpg",
                    Title = "Kalite ve Konfor",
                    Subtitle = "Bilge Hotel'e Hoşgeldiniz...",
                    Paragraph1 = "Bilge Hotel Thermal Spa & Convention Center; Kemer şehir merkezinde, güler yüzlü ve profesyonel ekibi ile beklentilerin üzerinde hizmet vermektedir.",
                    Paragraph2 = "Bilge Hotel 35 yıllık deneyimi, misafir memnuniyeti odaklı hizmet anlayışı ile sizleri kaliteye ve konfora davet ediyor."
                }
                );
            #endregion

            #region HomePageSlide
            builder.Entity<HomePageSlide>().HasData(
                new HomePageSlide { ID = 1, PictureName = "Slide1", PictureUrl = "https://www.almira.com.tr/images/genel1.jpg", HomePageID = 1 },
                new HomePageSlide { ID = 2, PictureName = "Slide2", PictureUrl = "https://www.almira.com.tr/images/gallery/almira/04.jpg", HomePageID = 1 },
                new HomePageSlide { ID = 3, PictureName = "Slide3", PictureUrl = "https://www.almira.com.tr/images/gallery/almira/07.jpg", HomePageID = 1 }
                );
            #endregion

            #region Setting
            builder.Entity<Setting>().HasData(
                new Setting { ID = 1, HomePageID = 1, AboutusID = 1, ContactID = 1, SmtpHost = "smtp.gmail.com", SmtpPort = 587, SmtpEmail = "the.mstfa@gmail.com", SmtpPassword = "Mustafa.2525774" } //Todo: Email değiştirilecek.
                );
            #endregion

            #region HotelService
            builder.Entity<HotelService>().HasData(
                new HotelService { ID = 1, IconPicture = "https://roof264.com/media/image/mobil/oda-servisi.jpg", ServiceName = "Oda Servisi", SettingID = 1 },
                new HotelService { ID = 2, IconPicture = "https://roof264.com/media/image/mobil/ucretsiz-wi-fi.jpg", ServiceName = "Ücretsiz Wifi", SettingID = 1 },
                new HotelService { ID = 3, IconPicture = "https://roof264.com/media/image/mobil/camasir-yikama.jpg", ServiceName = "Çamaşır Yıkama", SettingID = 1 },
                new HotelService { ID = 4, IconPicture = "https://roof264.com/media/image/mobil/oda-ici-kasa.jpg", ServiceName = "Kasa", SettingID = 1 },
                new HotelService { ID = 5, IconPicture = "https://roof264.com/media/image/mobil/toplanti-olanaklari-max-10.jpg", ServiceName = "Toplantı Olanakları", SettingID = 1 },
                new HotelService { ID = 6, IconPicture = "https://roof264.com/media/image/mobil/bagaj-depolama.jpg", ServiceName = "Bagaj Depolama", SettingID = 1 },
                new HotelService { ID = 7, IconPicture = "https://roof264.com/media/image/mobil/hizli-c-in-c-out.jpg", ServiceName = "Hızlı C in / C out", SettingID = 1 },
                new HotelService { ID = 8, IconPicture = "https://roof264.com/media/image/mobil/kuru-temizleme.jpg", ServiceName = "Kuru Temizleme", SettingID = 1 },
                new HotelService { ID = 9, IconPicture = "https://roof264.com/media/image/mobil/bebek-karyolasi.jpg", ServiceName = "Bebek Karyolası", SettingID = 1 },
                new HotelService { ID = 10, IconPicture = "https://roof264.com/media/image/mobil/aile-odasi.jpg", ServiceName = "Aile Odası", SettingID = 1 },
                new HotelService { ID = 11, IconPicture = "https://roof264.com/media/image/mobil/sicak-kahvalti.jpg", ServiceName = "Sıcak Kahvaltı", SettingID = 1 },
                new HotelService { ID = 12, IconPicture = "https://roof264.com/media/image/mobil/merkezi-konum.jpg", ServiceName = "Merkezi Konum", SettingID = 1 },
                new HotelService { ID = 13, IconPicture = "https://roof264.com/media/image/mobil/ucretsiz-acik-kapali-otopark.jpg", ServiceName = "Ücretsiz Açık / Kapalı Otopark", SettingID = 1 },
                new HotelService { ID = 14, IconPicture = "https://roof264.com/media/image/mobil/utu-hizmeti.jpg", ServiceName = "Ütü Hizmeti", SettingID = 1 },
                new HotelService { ID = 15, IconPicture = "https://roof264.com/media/image/mobil/cay-kahve-hizmeti.jpg", ServiceName = "Çay - Kahve Hizmeti", SettingID = 1 }
                );
            #endregion

            //Management
            #region DepartmentData
            builder.Entity<Department>().HasData(
                    new Department { ID = 1, DepartmentName = "Yardımcı Hizmetler" },
                    new Department { ID = 2, DepartmentName = "Bilgi İşlem" },
                    new Department { ID = 3, DepartmentName = "Mutfak" },
                    new Department { ID = 4, DepartmentName = "Resepsiyon" },
                    new Department { ID = 5, DepartmentName = "Yönetim" },
                    new Department { ID = 6, DepartmentName = "İnsan Kaynakları" }
                );
            #endregion

            #region EmployeeData
            List<Employee> employees = new List<Employee>();

            void FakeEmployee(string title, int departmentId, EmployeeStatus status)
            {
                var employee = new Faker<Employee>()
                    .RuleFor(x => x.FirstName, x => x.Person.FirstName)
                    .RuleFor(x => x.LastName, x => x.Person.LastName)
                    .RuleFor(x => x.StartDateOfWork, x => x.Date.Between(DateTime.Parse("2019-01-01"), DateTime.Now))
                    .RuleFor(x => x.HourlyRate, x => x.Random.Decimal(190, 200))
                    .RuleFor(x => x.IdentificationNumber, x => x.Random.ULong(1111, 9999).ToString())
                    .RuleFor(x => x.Email, x => x.Person.Email)
                    .RuleFor(x => x.PhoneNumber, x => x.Phone.PhoneNumber("05454526235"));
                Employee emp = employee;
                emp.ID = employees.Count + 1; emp.Title = title; emp.EmployeeStatus = status; emp.DepartmentID = departmentId; emp.IsActive = true;
                employees.Add(emp);
            }

            for (int i = 1; i <= 7; i++)
            {
                FakeEmployee("Resepsiyonist", 4, EmployeeStatus.Worker);
            }
            for (int i = 1; i <= 11; i++)
            {
                FakeEmployee("Temizlik Görevlisi", 1, EmployeeStatus.Worker);
            }
            for (int i = 1; i <= 11; i++)
            {
                FakeEmployee("Aşçı", 3, EmployeeStatus.Worker);
            }
            for (int i = 1; i <= 13; i++)
            {
                FakeEmployee("Garson", 3, EmployeeStatus.Worker);
            }

            FakeEmployee("Elektirikçi", 1, EmployeeStatus.Worker);
            FakeEmployee("Bilgi İşlem Sorumlusu", 2, EmployeeStatus.Worker);
            FakeEmployee("Müdür", 5, EmployeeStatus.SeniorManagement);
            FakeEmployee("İnsan Kaynakları Müdürü", 6, EmployeeStatus.MiddleManagement);

            builder.Entity<Employee>().HasData(employees);
            #endregion

            #region SalaryData
            builder.Entity<Salary>().HasData(
                    new Salary { ID = 1, EmployeeID = 1, MonthlySalary = 5000, BeenPaid = true, Month = "Şubat", PaymentDate = DateTime.Parse("2022-03-05") },
                    new Salary { ID = 2, EmployeeID = 2, MonthlySalary = 5500, BeenPaid = true, Month = "Şubat", PaymentDate = DateTime.Parse("2022-03-05") },
                    new Salary { ID = 3, EmployeeID = 1, MonthlySalary = 5000, BeenPaid = false, Month = "Mart" },
                    new Salary { ID = 4, EmployeeID = 2, MonthlySalary = 5500, BeenPaid = false, Month = "Mart" }
                    );
            #endregion

            #region ShiftData
            builder.Entity<Shift>().HasData(
                new Shift { ID = 1, StartTime = TimeSpan.FromHours(08), EndTime = TimeSpan.FromHours(16), ShiftName = "Gündüz" },
                new Shift { ID = 2, StartTime = TimeSpan.FromHours(16), EndTime = TimeSpan.FromHours(00), ShiftName = "Akşam" },
                new Shift { ID = 3, StartTime = TimeSpan.FromHours(00), EndTime = TimeSpan.FromHours(08), ShiftName = "Gece" }
                );
            #endregion

            #region WorkScheduleData
            builder.Entity<WorkSchedule>().HasData(
                new WorkSchedule { ID = 1, EmployeeID = 1, Date = DateTime.Parse("2022-03-14"), TotalWorkTime = TimeSpan.FromHours(8), TimesWorked = TimeSpan.FromHours(8), HaveOverTime = false, IsHoliday = true, Holiday=Holiday.Off, ShiftID = 1 },
                new WorkSchedule { ID = 2, EmployeeID = 2, Date = DateTime.Parse("2022-03-14"), TotalWorkTime = TimeSpan.FromHours(8), TimesWorked = TimeSpan.FromHours(8), HaveOverTime = false, IsHoliday = false, ShiftID = 1 }
                );
            #endregion

            #region EmployeeShift
            builder.Entity<EmployeeShift>().HasData(
                new EmployeeShift { EmployeeID = 1, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 2, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 3, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 4, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 5, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 6, ShiftID = 3 },
                new EmployeeShift { EmployeeID = 7, ShiftID = 3 },

                new EmployeeShift { EmployeeID = 8, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 9, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 10, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 11, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 12, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 13, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 14, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 15, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 16, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 17, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 18, ShiftID = 2 },

                new EmployeeShift { EmployeeID = 19, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 20, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 21, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 22, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 23, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 24, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 25, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 26, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 27, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 28, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 29, ShiftID = 2 },

                new EmployeeShift { EmployeeID = 30, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 31, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 32, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 33, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 34, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 35, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 36, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 37, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 38, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 39, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 40, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 41, ShiftID = 2 },
                new EmployeeShift { EmployeeID = 42, ShiftID = 2 },

                new EmployeeShift { EmployeeID = 43, ShiftID = 1 },
                new EmployeeShift { EmployeeID = 44, ShiftID = 1 }
                );
            #endregion

            //Hotel
            #region RoomFacility
            builder.Entity<RoomFacility>().HasData(
                new RoomFacility { ID = 1, FacilityName = "Klima" },
                new RoomFacility { ID = 2, FacilityName = "Tv" },
                new RoomFacility { ID = 3, FacilityName = "Saç Kurutma Makinesi" },
                new RoomFacility { ID = 4, FacilityName = "Kablosuz Internet" },
                new RoomFacility { ID = 5, FacilityName = "Minibar" },
                new RoomFacility { ID = 6, FacilityName = "Balkon" }
                );
            #endregion

            #region RoomType
            builder.Entity<RoomType>().HasData(
                new RoomType { ID = 1, RoomTypeName="Single Room", NumberOfPeople=1, NumberOfBed=1, Price=600, Description= "15 - 20 m² Single Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda tek kişilik bir adet yatak bulunmaktadır."},
                new RoomType { ID = 2, RoomTypeName="Double Room", NumberOfPeople=2, NumberOfBed=2, Price=1050, Description= "20 - 25 m² Double Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda tek kişilik iki adet yatak bulunmaktadır."},
                new RoomType { ID = 3, RoomTypeName= "Double Superior Room", NumberOfPeople=2, NumberOfBed=1, Price=1050, Description= "20 - 25 m² Double Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda iki kişilik bir adet yatak bulunmaktadır."},
                new RoomType { ID = 4, RoomTypeName= "Triple Room", NumberOfPeople=3, NumberOfBed=3, Price=1500, Description= "25 - 30 m² Triple Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda üç adet tek kişilik yatak bulunmaktadır." },
                new RoomType { ID = 5, RoomTypeName= "Triple Superior Room", NumberOfPeople=3, NumberOfBed=2, Price=1500, Description= "25 - 30 m² Triple Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda bir adet tek kişilik, bir adet iki kişilik yatak bulunmaktadır." },
                new RoomType { ID = 6, RoomTypeName= "Family Room", NumberOfPeople=4, NumberOfBed=3, Price=1900, Description= "30 - 35 m² Family Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda bir adet çift kişilik, iki adet tek kişilik yatak bulunmaktadır."},
                new RoomType { ID = 7, RoomTypeName= "Presidential Suite", NumberOfPeople=2, NumberOfBed=1, Price=2500, Description= "Yatak odası, yemek yeme alanına sahip oturma salonu ve iki ayrı banyosuyla 85 m² olan geniş kullanım alanı, şehir ve dağ manzarası ile konforu sunuyor.Rahatlamak ve keyif almak için özel olarak tasarlanan jakuzili banyoda ruhunuzu ve bedeninizi dinlendirebilir, gününüzü keyifle noktalayabilirsiniz." }
                );
            #endregion

            #region FacilityOfRoom
            builder.Entity<FacilityOfRoom>().HasData(
                new FacilityOfRoom {RoomTypeID = 1, RoomFacilityID = 1 },
                new FacilityOfRoom {RoomTypeID = 1, RoomFacilityID = 2 },
                new FacilityOfRoom {RoomTypeID = 1, RoomFacilityID = 3 },
                new FacilityOfRoom {RoomTypeID = 1, RoomFacilityID = 4 },

                new FacilityOfRoom {RoomTypeID = 2, RoomFacilityID = 1 },
                new FacilityOfRoom {RoomTypeID = 2, RoomFacilityID = 2 },
                new FacilityOfRoom {RoomTypeID = 2, RoomFacilityID = 3 },
                new FacilityOfRoom {RoomTypeID = 2, RoomFacilityID = 4 },
                new FacilityOfRoom {RoomTypeID = 2, RoomFacilityID = 5 },

                new FacilityOfRoom { RoomTypeID = 3, RoomFacilityID = 1 },
                new FacilityOfRoom { RoomTypeID = 3, RoomFacilityID = 2 },
                new FacilityOfRoom { RoomTypeID = 3, RoomFacilityID = 3 },
                new FacilityOfRoom { RoomTypeID = 3, RoomFacilityID = 4 },
                new FacilityOfRoom { RoomTypeID = 3, RoomFacilityID = 5 },
                new FacilityOfRoom { RoomTypeID = 3, RoomFacilityID = 6 },

                new FacilityOfRoom { RoomTypeID = 4, RoomFacilityID = 1 },
                new FacilityOfRoom { RoomTypeID = 4, RoomFacilityID = 2 },
                new FacilityOfRoom { RoomTypeID = 4, RoomFacilityID = 3 },
                new FacilityOfRoom { RoomTypeID = 4, RoomFacilityID = 4 },
                new FacilityOfRoom { RoomTypeID = 4, RoomFacilityID = 5 },

                new FacilityOfRoom { RoomTypeID = 5, RoomFacilityID = 1 },
                new FacilityOfRoom { RoomTypeID = 5, RoomFacilityID = 2 },
                new FacilityOfRoom { RoomTypeID = 5, RoomFacilityID = 3 },
                new FacilityOfRoom { RoomTypeID = 5, RoomFacilityID = 4 },
                new FacilityOfRoom { RoomTypeID = 5, RoomFacilityID = 5 },
                new FacilityOfRoom { RoomTypeID = 5, RoomFacilityID = 6 },

                new FacilityOfRoom { RoomTypeID = 6, RoomFacilityID = 1 },
                new FacilityOfRoom { RoomTypeID = 6, RoomFacilityID = 2 },
                new FacilityOfRoom { RoomTypeID = 6, RoomFacilityID = 3 },
                new FacilityOfRoom { RoomTypeID = 6, RoomFacilityID = 4 },
                new FacilityOfRoom { RoomTypeID = 6, RoomFacilityID = 5 },
                new FacilityOfRoom { RoomTypeID = 6, RoomFacilityID = 6 },

                new FacilityOfRoom { RoomTypeID = 7, RoomFacilityID = 1 },
                new FacilityOfRoom { RoomTypeID = 7, RoomFacilityID = 2 },
                new FacilityOfRoom { RoomTypeID = 7, RoomFacilityID = 3 },
                new FacilityOfRoom { RoomTypeID = 7, RoomFacilityID = 4 },
                new FacilityOfRoom { RoomTypeID = 7, RoomFacilityID = 5 },
                new FacilityOfRoom { RoomTypeID = 7, RoomFacilityID = 6 }
                );
            #endregion

            #region RoomPicture
            builder.Entity<RoomPicture>().HasData(
                new RoomPicture { ID = 1, RoomTypeID=1, PictureUrl="/img/roomtypes/room-single.jpg"},
                new RoomPicture { ID = 2, RoomTypeID=2, PictureUrl="/img/roomtypes/room-double.jpg"},
                new RoomPicture { ID = 3, RoomTypeID=3, PictureUrl="/img/roomtypes/room-double-superrior.jpg"},
                new RoomPicture { ID = 4, RoomTypeID=4, PictureUrl="/img/roomtypes/room-triple.jpg"},
                new RoomPicture { ID = 5, RoomTypeID=5, PictureUrl="/img/roomtypes/room-triple-superrior.jpg"},
                new RoomPicture { ID = 6, RoomTypeID=6, PictureUrl="/img/roomtypes/room-family.jpg"},
                new RoomPicture { ID = 7, RoomTypeID=7, PictureUrl="/img/roomtypes/room-presidential-suite.jpg"}
                );
            #endregion

            #region Room
            List<Room> rooms = new List<Room>();
            int sayi=100;
            //1. Kat 1 nolu tip
            for (int i = 0; i < 10; i++)
            {
                Room room = new Room();
                room.ID = sayi - 99;
                room.FloorNumber = 1;
                room.RoomNumber = sayi.ToString();
                room.RoomTypeID = 1;
                room.RoomStatus = RoomStatus.Bos;

                rooms.Add(room);
                sayi++;
            }
            //1. Kat 4 nolu tip
            for (int i = 0; i < 10; i++)
            {
                Room room = new Room();
                room.ID = sayi - 99;
                room.FloorNumber = 1;
                room.RoomNumber = sayi.ToString();
                room.RoomTypeID = 4;
                room.RoomStatus = RoomStatus.Bos;

                rooms.Add(room);
                sayi++;
            }
            //2. Kat 1 nolu tip
            for (int i = 0; i < 10; i++)
            {
                Room room = new Room();
                room.ID = sayi - 99;
                room.FloorNumber = 2;
                room.RoomNumber = sayi.ToString();
                room.RoomTypeID = 1;
                room.RoomStatus = RoomStatus.Bos;

                rooms.Add(room);
                sayi++;
            }
            //2. Kat 2 nolu tip
            for (int i = 0; i < 10; i++)
            {
                Room room = new Room();
                room.ID = sayi - 99;
                room.FloorNumber = 2;
                room.RoomNumber = sayi.ToString();
                room.RoomTypeID = 2;
                room.RoomStatus = RoomStatus.Bos;

                rooms.Add(room);
                sayi++;
            }
            //3. Kat 3 nolu tip
            for (int i = 0; i < 10; i++)
            {
                Room room = new Room();
                room.ID = sayi - 99;
                room.FloorNumber = 3;
                room.RoomNumber = sayi.ToString();
                room.RoomTypeID = 3;
                room.RoomStatus = RoomStatus.Bos;

                rooms.Add(room);
                sayi++;
            }
            //3. Kat 5 nolu tip
            for (int i = 0; i < 10; i++)
            {
                Room room = new Room();
                room.ID = sayi - 99;
                room.FloorNumber = 3;
                room.RoomNumber = sayi.ToString();
                room.RoomTypeID = 5;
                room.RoomStatus = RoomStatus.Bos;

                rooms.Add(room);
                sayi++;
            }
            //4. Kat 3 nolu tip
            for (int i = 0; i < 10; i++)
            {
                Room room = new Room();
                room.ID = sayi - 99;
                room.FloorNumber = 4;
                room.RoomNumber = sayi.ToString();
                room.RoomTypeID = 3;
                room.RoomStatus = RoomStatus.Bos;

                rooms.Add(room);
                sayi++;
            }
            //4. Kat 6 nolu tip
            for (int i = 0; i < 6; i++)
            {
                Room room = new Room();
                room.ID = sayi - 99;
                room.FloorNumber = 4;
                room.RoomNumber = sayi.ToString();
                room.RoomTypeID = 6;
                room.RoomStatus = RoomStatus.Bos;

                rooms.Add(room);
                sayi++;
            }
            //4. Kat 7 nolu tip
            Room room1 = new Room();
            room1.ID = sayi - 99;
            room1.FloorNumber = 4;
            room1.RoomNumber = sayi.ToString();
            room1.RoomTypeID = 7;
            room1.RoomStatus = RoomStatus.Bos;

            rooms.Add(room1);

            builder.Entity<Room>().HasData(rooms);
            #endregion

            #region ServicePack
            builder.Entity<ServicePack>().HasData(
                new ServicePack { ID = 1, PackName = "Tam Pansiyon", PackPrice = 200, Description = "Bu pakette sabah kahvaltısı, öğle yemeği ve akşam yemekleri konaklama ücretine dahildir." },
                new ServicePack { ID = 2, PackName = "Her Şey Dahil", PackPrice = 500, Description = "Bu pakette konaklama süresince 3 öğün yemekler, 5 çayı ve atıştırmalıklarla gün boyunca içecekler (alkolsüz içeceklerle - yerli alkollü içecekler) konaklama ücretine dahildir. Otellerdeki aktiviteler bu konseptte dahil değildir." }
                );
            #endregion

            #region ExtraService
            builder.Entity<ExtraService>().HasData(
                new ExtraService { ID = 1, ServiceName = "Sauna", Price = 600 }
                );
            #endregion

            //User
            #region Role
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "c62f42df-2d75-4102-b281-a8637f2cb0a1", Name = "user", NormalizedName = "user".ToUpper() },
                new IdentityRole { Id = "bcf7061b-0a59-426a-9b49-f520e1b4849b", Name = "admin", NormalizedName = "admin".ToUpper() },
                new IdentityRole { Id = "3920b0ec-725e-4b34-ab67-27c7f816936d", Name = "resepsiyon", NormalizedName = "resepsiyon".ToUpper() },
                new IdentityRole { Id = "75d8b242-e230-4fe8-ad20-b8e818d97957", Name = "insankaynaklari", NormalizedName = "insankaynaklari".ToUpper() },
                new IdentityRole { Id = "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", Name = "yardimcihizmetler", NormalizedName = "yardimcihizmetler".ToUpper() }
                );
            #endregion

        }
    }
}
