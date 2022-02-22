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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-CAP6I0L\\SQLEXPRESS; Database=BilgeHotelDB; Trusted_Connection=True");
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
            //builder.ApplyConfiguration<BaseEntity>(new BaseMap());
            builder.ApplyConfiguration<Department>(new DepartmentMap());
            builder.ApplyConfiguration<Employee>(new EmployeeMap());
            builder.ApplyConfiguration<ExtraService>(new ExtraServiceMap());
            builder.ApplyConfiguration<FacilityOfRoom>(new FacilityOfRoomMap());
            builder.ApplyConfiguration<Guest>(new GuestMap());
            builder.ApplyConfiguration<Income>(new IncomeMap());
            builder.ApplyConfiguration<ReceptionReservation>(new ReceptionReservationMap());
            builder.ApplyConfiguration<Registration>(new RegistrationMap());
            builder.ApplyConfiguration<RoomFacility>(new RoomFacilityMap());
            builder.ApplyConfiguration<Room>(new RoomMap());
            builder.ApplyConfiguration<RoomPicture>(new RoomPictureMap());
            builder.ApplyConfiguration<RoomType>(new RoomTypeMap());
            builder.ApplyConfiguration<Salary>(new SalaryMap());
            builder.ApplyConfiguration<ServicePack>(new ServicePackMap());
            builder.ApplyConfiguration<Shift>(new ShiftMap());
            builder.ApplyConfiguration<StatusOfRoom>(new StatusOfRoomMap());
            builder.ApplyConfiguration<UseOfExtraService>(new UseOfExtraServiceMap());
            builder.ApplyConfiguration<WebReservation>(new WebReservationMap());
            builder.ApplyConfiguration<WorkSchedule>(new WorkScheduleMap());

            builder.Seed();
            base.OnModelCreating(builder);
        }

    }
}
