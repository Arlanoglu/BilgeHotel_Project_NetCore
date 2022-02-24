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

            return services;
        }
    }
}
