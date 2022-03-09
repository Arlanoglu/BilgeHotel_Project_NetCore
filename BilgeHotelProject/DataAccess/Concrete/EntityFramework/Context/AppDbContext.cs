using Core.Entities;
using DataAccess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-CAP6I0L\\SQLEXPRESS; Database=BilgeHotelDB; Trusted_Connection=True");
        //}
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ExtraService> ExtraServices { get; set; }
        public DbSet<FacilityOfRoom> FacilitiesOfRooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<ReceptionReservation> ReceptionReservations { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomPicture> RoomPictures { get; set; }
        public DbSet<RoomFacility> RoomFacilities { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<ServicePack> ServicePacks { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<StatusOfRoom> StatusesOfRooms { get; set; }
        public DbSet<UseOfExtraService> UseOfExtraServices { get; set; }
        public DbSet<WebReservation> WebReservations { get; set; }
        public DbSet<WorkSchedule> WorkSchedules { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<EmployeeShift> EmployeesShifts { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Aboutus> Aboutus { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<HomePageSlide> HomePageSlides { get; set; }
        public DbSet<HotelService> HotelServices { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public override int SaveChanges()
        {
            var modifiedEntiries = ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);

            DateTime dateTime = DateTime.Now;

            try
            {
                foreach (var item in modifiedEntiries)
                {
                    var entityRepository = item.Entity as BaseEntity;
                    if (entityRepository != null)
                    {
                        if (item.State == EntityState.Added)
                        {
                            entityRepository.CreatedDate = dateTime;
                        }
                        else if(item.State == EntityState.Modified)
                        {
                            entityRepository.ModifiedDate = dateTime;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ContactMap());
            builder.ApplyConfiguration(new HomePageSlideMap());
            builder.ApplyConfiguration(new HotelServiceMap());
            builder.ApplyConfiguration(new HomePageMap());
            builder.ApplyConfiguration(new SettingMap());
            builder.ApplyConfiguration(new PictureMap());
            builder.ApplyConfiguration(new AboutusMap());

            builder.ApplyConfiguration(new DepartmentMap());
            builder.ApplyConfiguration(new EmployeeMap());
            builder.ApplyConfiguration(new ExtraServiceMap());
            builder.ApplyConfiguration(new FacilityOfRoomMap());
            builder.ApplyConfiguration(new GuestMap());
            builder.ApplyConfiguration(new IncomeMap());
            builder.ApplyConfiguration(new ReceptionReservationMap());
            builder.ApplyConfiguration(new RegistrationMap());
            builder.ApplyConfiguration(new RoomFacilityMap());
            builder.ApplyConfiguration(new RoomMap());
            builder.ApplyConfiguration(new RoomPictureMap());
            builder.ApplyConfiguration(new RoomTypeMap());
            builder.ApplyConfiguration(new SalaryMap());
            builder.ApplyConfiguration(new ServicePackMap());
            builder.ApplyConfiguration(new ShiftMap());
            builder.ApplyConfiguration(new StatusOfRoomMap());
            builder.ApplyConfiguration(new UseOfExtraServiceMap());
            builder.ApplyConfiguration(new WebReservationMap());
            builder.ApplyConfiguration(new WorkScheduleMap());
            builder.ApplyConfiguration(new EmployeeShiftMap());

            builder.Seed();
            base.OnModelCreating(builder);
        }

    }
}
