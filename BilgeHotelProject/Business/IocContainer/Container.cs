using Business.Services.Abstract;
using Business.Services.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IocContainer
{
    public static class Container
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IResult, Result>();

            services.AddScoped<IDepartmentService, DepartmentManager>();
            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IExtraServiceService, ExtraServiceManager>();
            services.AddScoped<IFacilityOfRoomService, FacilityOfRoomManager>();
            services.AddScoped<IGuestService, GuestManager>();
            services.AddScoped<IIncomeService, IncomeManager>();
            services.AddScoped<IReceptionReservationService, ReceptionReservationManager>();
            services.AddScoped<IRegistrationService, RegistrationManager>();
            services.AddScoped<IRoomFacilityService, RoomFacilityManager>();
            services.AddScoped<IRoomService, RoomManager>();
            services.AddScoped<IRoomTypeService, RoomTypeManager>();
            services.AddScoped<ISalaryService, SalaryManager>();
            services.AddScoped<IServicePackService, ServicePackManager>();
            services.AddScoped<IShiftService, ShiftManager>();
            services.AddScoped<IStatusOfRoomService, StatusOfRoomManager>();
            services.AddScoped<IUseOfExtraServiceService, UseOfExtraServiceManager>();
            services.AddScoped<IWebReservationService, WebReservationManager>();
            services.AddScoped<IWorkScheduleService, WorkScheduleManager>();
            services.AddScoped<IPictureService, PictureManager>();
            services.AddScoped<IAboutusService, AboutusManager>();
            services.AddScoped<IHomePageService, HomePageManager>();
            services.AddScoped<IHomePageSlideService, HomePageSlideManager>();
            services.AddScoped<IHotelServiceService, HotelServiceManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<ISettingService, SettingManager>();
            services.AddScoped<IEmployeeShiftService, EmployeeShiftManager>();

            services.AddScoped<IDepartmentDal, EFDepartmentDal>();
            services.AddScoped<IEmployeeDal, EFEmployeeDal>();
            services.AddScoped<IExtraServiceDal, EFExtraServiceDal>();
            services.AddScoped<IFacilityOfRoomDal, EFFacilityOfRoomDal>();
            services.AddScoped<IGuestDal, EFGuestDal>();
            services.AddScoped<IIncomeDal, EFIncomeDal>();
            services.AddScoped<IReceptionReservationDal, EFReceptionReservationDal>();
            services.AddScoped<IRegistrationDal, EFRegistrationDal>();
            services.AddScoped<IRoomDal, EFRoomDal>();
            services.AddScoped<IRoomFacilityDal, EFRoomFacilityDal>();
            services.AddScoped<IRoomTypeDal, EFRoomTypeDal>();
            services.AddScoped<ISalaryDal, EFSalaryDal>();
            services.AddScoped<IServicePackDal, EFServicePackDal>();
            services.AddScoped<IShiftDal, EFShiftDal>();
            services.AddScoped<IStatusOfRoomDal, EFStatusOfRoomDal>();
            services.AddScoped<IUseOfExtraServiceDal, EFUseOfExtraServiceDal>();
            services.AddScoped<IWebReservationDal, EFWebReservationDal>();
            services.AddScoped<IWorkScheduleDal, EFWorkScheduleDal>();
            services.AddScoped<IPictureDal, EFPictureDal>();
            services.AddScoped<IAboutusDal, EFAboutusDal>();
            services.AddScoped<IHomePageDal, EFHomePageDal>();
            services.AddScoped<IHomePageSlideDal, EFHomePageSlideDal>();
            services.AddScoped<IHotelServiceDal, EFHotelServiceDal>();
            services.AddScoped<IContactDal, EFContactDal>();
            services.AddScoped<ISettingDal, EFSettingDal>();
            services.AddScoped<IEmployeeShiftDal, EFEmployeeShiftDal>();

            return services;
        }
    }
}
