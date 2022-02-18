using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-CAP6I0L\\SQLEXPRESS; Database=Northwind; Trusted_Connection=True");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeStatus> EmployeeStatuses { get; set; }
        public DbSet<ExtraService> ExtraServices { get; set; }
        public DbSet<FacilityOfRoom> FacilitiesOfRooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<ReceptionReservation> ReceptionReservations { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomFacility> RoomFacilities { get; set; }
        public DbSet<RoomStatus> RoomStatuses { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<ServicePack> ServicePacks { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<StatusOfRoom> StatusesOfRooms { get; set; }
        public DbSet<UseOfExtraService> UseOfExtraServices { get; set; }
        public DbSet<WebReservation> WebReservations { get; set; }
        public DbSet<WorkSchedule> WorkSchedules { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }

    }
}
