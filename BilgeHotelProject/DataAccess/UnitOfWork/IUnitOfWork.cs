﻿using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentDal DepartmentDal { get; }
        IEmployeeDal EmployeeDal { get; }
        IExtraServiceDal ExtraServiceDal { get; }
        IFacilityOfRoomDal FacilityOfRoomDal { get; }
        IGuestDal GuestDal { get; }
        IIncomeDal IncomeDal { get; }
        IReceptionReservationDal ReceptionReservationDal { get; }
        IRegistrationDal RegistrationDal { get; }
        IRoomDal RoomDal { get; }
        IRoomFacilityDal RoomFacilityDal { get; }
        IRoomTypeDal RoomTypeDal { get; }
        ISalaryDal SalaryDal { get; }
        IServicePackDal ServicePackDal { get; }
        IShiftDal ShiftDal { get; }
        IStatusOfRoomDal StatusOfRoomDal { get; }
        IUseOfExtraServiceDal UseOfExtraServiceDal { get; }
        IWebReservationDal WebReservationDal { get; }
        IWorkScheduleDal WorkScheduleDal { get; }

        int SaveChange();


    }
}
