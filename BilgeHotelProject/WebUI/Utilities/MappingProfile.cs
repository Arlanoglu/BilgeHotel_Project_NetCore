using AutoMapper;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Aboutus;
using WebUI.Models.Contact;
using WebUI.Models.HomePage;
using WebUI.Models.Picture;
using WebUI.Models.RoomType;
using WebUI.Models.HotelService;
using WebUI.Models.RoomFacility;
using WebUI.Models.Reservation;
using WebUI.Models.ServicePack;
using WebUI.Models.Account;
using WebUI.Models.StatusOfRoom;
using WebUI.Models.Registration;
using WebUI.Models.Guest;
using WebUI.Models.ExtraService;
using WebUI.Models.Room;
using WebUI.Models.Employee;
using WebUI.Models.Shift;
using WebUI.Models.Department;
using Microsoft.AspNetCore.Identity;
using WebUI.Models.WorkSchedule;
using WebUI.Models.Salary;

namespace WebUI.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HomePage, VMHomePage>();
            CreateMap<VMHomePage, HomePage>();

            CreateMap<HomePageSlide, VMHomePageSlide>();
            CreateMap<VMHomePageSlide, HomePageSlide>();

            CreateMap<RoomType, VMRoomType>();
            CreateMap<VMRoomType, RoomType>();
            CreateMap<VMRoomTypeName, RoomType>();
            CreateMap<RoomType, VMRoomTypeName>();
            CreateMap<RoomPicture, VMRoomPicture>();
            CreateMap<VMRoomPicture, RoomPicture>();

            CreateMap<RoomType, VMRoomTypeDetail>()
                .ForMember(x => x.RoomTypeID, w => w.MapFrom(y => y.ID));
            CreateMap<VMRoomTypeDetail, RoomType>();

            CreateMap<Contact, VMContact>();
            CreateMap<VMContact, Contact>();
            CreateMap<VMSocialMedia, Contact>();
            CreateMap<Contact, VMSocialMedia>();

            CreateMap<Aboutus, VMAboutus>();
            CreateMap<VMAboutus, Aboutus>();

            CreateMap<Picture, VMPicture>();
            CreateMap<VMPicture, Picture>();

            CreateMap<HotelService, VMHotelService>();
            CreateMap<VMHotelService, HotelService>();

            CreateMap<VMRoomFacility, RoomFacility>();
            CreateMap<RoomFacility, VMRoomFacility>();

            CreateMap<WebReservation, VMWebReservation>();
            CreateMap<VMWebReservation, WebReservation>();

            CreateMap<ServicePack, VMServicePack>();
            CreateMap<VMServicePack, ServicePack>();

            CreateMap<ServicePack, VMServicePackList>()
                .ForMember(x => x.ServicePackID, w => w.MapFrom(y => y.ID));
            CreateMap<VMServicePackList, ServicePack>();

            CreateMap<ServicePack, VMServicePackCreate>();
            CreateMap<VMServicePackCreate, ServicePack>();

            CreateMap<ServicePack, VMServicePackUpdate>()
                .ForMember(x => x.ServicePackID, w => w.MapFrom(y => y.ID));
            CreateMap<VMServicePackUpdate, ServicePack>();

            CreateMap<AppUser, VMLogin>();
            CreateMap<VMLogin, AppUser>();

            CreateMap<VMRegister, AppUser>();
            CreateMap<AppUser, VMRegister>();

            CreateMap<AppUser, VMUserSession>();
            CreateMap<VMUserSession, AppUser>();

            CreateMap<VMReservation, VMWebReservation>();
            CreateMap<VMWebReservation, VMReservation>();

            CreateMap<VMStatusOfRoom, StatusOfRoom>();
            CreateMap<StatusOfRoom, VMStatusOfRoom>();

            CreateMap<VMMyReservation, WebReservation>();
            CreateMap<WebReservation, VMMyReservation>();

            CreateMap<Message, VMMessage>();
            CreateMap<VMMessage, Message>();

            CreateMap<VMReservationList, WebReservation>();
            CreateMap<WebReservation, VMReservationList>().ForMember(x => x.RoomTypeName, w => w.MapFrom(y => y.RoomType.RoomTypeName));
            CreateMap<ReceptionReservation, VMReservationList>().ForMember(x => x.RoomTypeName, w => w.MapFrom(y => y.RoomType.RoomTypeName));
            CreateMap<VMReservationList, ReceptionReservation>();

            CreateMap<VMReservationDetail, WebReservation>();
            CreateMap<WebReservation, VMReservationDetail>()
                .ForMember(x => x.RoomTypeName, w => w.MapFrom(y => y.RoomType.RoomTypeName))
                .ForMember(x => x.ServicePackName, w => w.MapFrom(y => y.ServicePack.PackName))
                .ForMember(x => x.RoomNumber, w => w.MapFrom(y => y.Room.RoomNumber))
                .ForMember(x => x.AppUserEmail, w => w.MapFrom(y => y.AppUser.Email))
                .ForMember(x => x.AppUserFullName, w => w.MapFrom(y => y.AppUser.FirstName + " " + y.AppUser.LastName));
            CreateMap<ReceptionReservation, VMReservationDetail>()
                .ForMember(x => x.RoomTypeName, w => w.MapFrom(y => y.RoomType.RoomTypeName))
                .ForMember(x => x.ServicePackName, w => w.MapFrom(y => y.ServicePack.PackName))
                .ForMember(x => x.RoomNumber, w => w.MapFrom(y => y.Room.RoomNumber));
            CreateMap<VMReservationDetail, ReceptionReservation>();

            CreateMap<VMReservationDetail, VMReservationList>();
            CreateMap<VMReservationList, VMReservationDetail>();

            CreateMap<VMReceptionReservationCreate, ReceptionReservation>();
            CreateMap<ReceptionReservation, VMReceptionReservationCreate>();

            CreateMap<VMReservation, VMReceptionReservationCreate>();
            CreateMap<VMReceptionReservationCreate, VMReservation>();

            CreateMap<VMGuestRegistrationList, Guest>();
            CreateMap<Guest, VMGuestRegistrationList>();

            CreateMap<VMExtraService, ExtraService>();
            CreateMap<ExtraService, VMExtraService>();

            CreateMap<ExtraService, VMExtraServiceList>()
               .ForMember(x => x.ServiceID, w => w.MapFrom(y => y.ID));
            CreateMap<VMExtraServiceList, ExtraService>();

            CreateMap<UseOfExtraService, VMUseOfExtraServiceCreate>();
            CreateMap<VMUseOfExtraServiceCreate, UseOfExtraService>();

            CreateMap<Registration, VMRegistrationList>()
                .ForMember(x => x.RoomNumber, w => w.MapFrom(y => y.Room.RoomNumber))
                .ForMember(x => x.ServicePackName, w => w.MapFrom(y => y.ServicePack.PackName));
            CreateMap<VMRegistrationList, Registration>();

            CreateMap<Registration, VMRegistrationDetail>()
                .ForMember(x => x.RoomNumber, w => w.MapFrom(y => y.Room.RoomNumber))
                .ForMember(x => x.RoomTypeName, w => w.MapFrom(y => y.Room.RoomType.RoomTypeName))
                .ForMember(x => x.VMGuests, w => w.MapFrom(y => y.GuestRegistrations.Select(q => q.Guest)))
                .ForMember(x => x.VMExtraServices, w => w.MapFrom(y => y.UseOfExtraServices.Select(q => q.ExtraService)))
                .ForMember(x => x.ServicePackName, w => w.MapFrom(y => y.ServicePack.PackName));
            CreateMap<VMRegistrationDetail, Registration>();

            CreateMap<Registration, VMRegistrationCreate>();
            CreateMap<VMRegistrationCreate, Registration>();

            CreateMap<ReceptionReservation, Registration>().ForMember(x => x.ReservationID, w => w.MapFrom(y => y.ID));
            CreateMap<Registration, ReceptionReservation>();
            CreateMap<WebReservation, Registration>();
            CreateMap<Registration, WebReservation>();

            CreateMap<Guest, VMGuestList>();
            CreateMap<VMGuestList, Guest>();

            CreateMap<Guest, VMGuestRegistrationSelection>();//Hata alınabilir.
            CreateMap<VMGuestRegistrationSelection, Guest>();

            CreateMap<Guest, VMGuestDetail>();
            CreateMap<VMGuestDetail, Guest>();

            CreateMap<VMGuestCreate, Guest>();
            CreateMap<Guest, VMGuestCreate>();

            CreateMap<Room, VMRoomList>().ForMember(x => x.RoomTypeName, w => w.MapFrom(y => y.RoomType.RoomTypeName));
            CreateMap<VMRoomList, Room>();

            CreateMap<Room, VMRoomUpdate>().ForMember(x => x.RoomID, w => w.MapFrom(y => y.ID));
            CreateMap<VMRoomUpdate, Room>();

            CreateMap<Room, VMRoomCreate>();
            CreateMap<VMRoomCreate, Room>();

            CreateMap<Employee, VMEmployeeList>()
                .ForMember(x => x.DepartmentName, w => w.MapFrom(y => y.Department.DepartmentName))
                .ForMember(x => x.ShiftName, w => w.MapFrom(y => y.Shift.ShiftName));
            CreateMap<VMEmployeeList, Employee>();

            CreateMap<Employee, VMEmployeeDetail>()
                .ForMember(x => x.DepartmentName, w => w.MapFrom(y => y.Department.DepartmentName))
                .ForMember(x => x.ShiftName, w => w.MapFrom(y => y.Shift.ShiftName));
            CreateMap<VMEmployeeDetail, Employee>();

            CreateMap<Employee, VMAddShiftToEmployee>()
                .ForMember(x => x.DepartmentName, w => w.MapFrom(y => y.Department.DepartmentName))
                .ForMember(x => x.ShiftName, w => w.MapFrom(y => y.Shift.ShiftName));
            CreateMap<VMAddShiftToEmployee, Employee>();

            CreateMap<Employee, VMEmployeeDelete>()
                .ForMember(x => x.DepartmentName, w => w.MapFrom(y => y.Department.DepartmentName));
            CreateMap<VMEmployeeDelete, VMEmployeeDelete>();

            CreateMap<Employee, VMEmployeeCreate>();
            CreateMap<VMEmployeeCreate, Employee>();

            CreateMap<Employee, VMEmployeeActivate>().ForMember(x => x.EmployeeID, w => w.MapFrom(y => y.ID));
            CreateMap<VMEmployeeActivate, Employee>();

            CreateMap<Employee, VMEmployeeUpdate>().ForMember(x => x.EmployeeID, w => w.MapFrom(y => y.ID));
            CreateMap<VMEmployeeUpdate, Employee>();

            CreateMap<VMEmployeeCreate, AppUser>();
            CreateMap<VMEmployeeActivate, AppUser>();
            CreateMap<VMEmployeeUpdate, AppUser>();

            CreateMap<Shift, VMShiftList>();
            CreateMap<VMShiftList, Shift>();

            CreateMap<Shift, VMShiftCreate>();
            CreateMap<VMShiftCreate, Shift>();

            CreateMap<Shift, VMShiftSelectList>();
            CreateMap<VMShiftSelectList, Shift>();

            CreateMap<Department, VMDepartmentSelectList>();
            CreateMap<VMDepartmentSelectList, Department>();

            CreateMap<IdentityRole, VMEmployeeRoleSelection>()
                .ForMember(x => x.RoleName, w => w.MapFrom(y => y.Name));

            CreateMap<Department, VMDepartmentList>();
            CreateMap<VMDepartmentList, Department>();

            CreateMap<Department, VMDepartmentCreate>();
            CreateMap<VMDepartmentCreate, Department>();

            CreateMap<Department, VMDepartmentUpdate>();
            CreateMap<VMDepartmentUpdate, Department>();

            CreateMap<WorkSchedule, VMWorkScheduleList>()
                .ForMember(x => x.EmployeeFullName, w => w.MapFrom(y => y.Employee.FirstName + " " + y.Employee.LastName))
                .ForMember(x => x.WorkScheduleID, w => w.MapFrom(y => y.ID));
            CreateMap<VMWorkScheduleList, WorkSchedule>();

            CreateMap<WorkSchedule, VMWorkScheduleDetail>()
                .ForMember(x => x.EmployeeFullName, w => w.MapFrom(y => y.Employee.FirstName + " " + y.Employee.LastName))
                .ForMember(x => x.EmployeeDepartment, w => w.MapFrom(y => y.Employee.Department.DepartmentName))
                .ForMember(x => x.EmployeeTitle, w => w.MapFrom(y => y.Employee.Title))
                .ForMember(x => x.WorkScheduleID, w => w.MapFrom(y => y.ID));
            CreateMap<VMWorkScheduleDetail, WorkSchedule>();

            CreateMap<WorkSchedule, VMWorkScheduleCreate>();
            CreateMap<VMWorkScheduleCreate, WorkSchedule>();

            CreateMap<Employee, VMWorkScheduleCreate>()
                .ForMember(x => x.EmployeeID, w => w.MapFrom(y => y.ID))
                .ForMember(x => x.EmployeeFullName, w => w.MapFrom(y => y.FirstName + " " + y.LastName))
                .ForMember(x => x.ShiftName, w => w.MapFrom(y => y.Shift.ShiftName))
                .ForMember(x => x.ShiftStartTime, w => w.MapFrom(y => y.Shift.StartTime))
                .ForMember(x => x.ShiftEndTime, w => w.MapFrom(y => y.Shift.EndTime));

            CreateMap<WorkSchedule, VMWorkScheduleUpdate>()
                .ForMember(x => x.WorkScheduleID, w => w.MapFrom(y => y.ID));
            CreateMap<VMWorkScheduleUpdate, WorkSchedule>();

            CreateMap<Salary, VMSalary>()
                .ForMember(x => x.SalaryID, w => w.MapFrom(y => y.ID))
                .ForMember(x => x.EmployeeName, w => w.MapFrom(y => y.Employee.FirstName+" "+y.Employee.LastName));
            CreateMap<VMSalary, Salary>();

            CreateMap<RoomFacility, VMRoomFacilitySelection>()
                .ForMember(x => x.FacilityName, w => w.MapFrom(y => y.FacilityName))
                .ForMember(x => x.FacilityID, w => w.MapFrom(y => y.ID));

            CreateMap<VMRoomFacilitySelection, FacilityOfRoom>()
                .ForMember(x => x.RoomFacilityID, w => w.MapFrom(y => y.FacilityID));

        }
    }
}
