﻿using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;

        public UnitOfWork(AppDbContext context, IDepartmentDal departmentDal, IEmployeeDal employeeDal, IExtraServiceDal extraServiceDal, IFacilityOfRoomDal facilityOfRoomDal, IGuestDal guestDal, IIncomeDal incomeDal, IReceptionReservationDal receptionReservationDal, IRegistrationDal registrationDal, IRoomDal roomDal, IRoomFacilityDal roomFacilityDal, IRoomTypeDal roomTypeDal, ISalaryDal salaryDal, IServicePackDal servicePackDal, IShiftDal shiftDal, IStatusOfRoomDal statusOfRoomDal, IUseOfExtraServiceDal useOfExtraServiceDal, IWebReservationDal webReservationDal, IWorkScheduleDal workScheduleDal)
        {
            this.context = context;
            DepartmentDal = departmentDal;
            EmployeeDal = employeeDal;
            ExtraServiceDal = extraServiceDal;
            FacilityOfRoomDal = facilityOfRoomDal;
            GuestDal = guestDal;
            IncomeDal = incomeDal;
            ReceptionReservationDal = receptionReservationDal;
            RegistrationDal = registrationDal;
            RoomDal = roomDal;
            RoomFacilityDal = roomFacilityDal;
            RoomTypeDal = roomTypeDal;
            SalaryDal = salaryDal;
            ServicePackDal = servicePackDal;
            ShiftDal = shiftDal;
            StatusOfRoomDal = statusOfRoomDal;
            UseOfExtraServiceDal = useOfExtraServiceDal;
            WebReservationDal = webReservationDal;
            WorkScheduleDal = workScheduleDal;
        }
        public IDepartmentDal DepartmentDal { get; }

        public IEmployeeDal EmployeeDal { get; }

        public IExtraServiceDal ExtraServiceDal { get; }

        public IFacilityOfRoomDal FacilityOfRoomDal { get; }

        public IGuestDal GuestDal { get; }

        public IIncomeDal IncomeDal { get; }

        public IReceptionReservationDal ReceptionReservationDal { get; }

        public IRegistrationDal RegistrationDal { get; }

        public IRoomDal RoomDal { get; }

        public IRoomFacilityDal RoomFacilityDal { get; }

        public IRoomTypeDal RoomTypeDal { get; }

        public ISalaryDal SalaryDal { get; }

        public IServicePackDal ServicePackDal { get; }

        public IShiftDal ShiftDal { get; }

        public IStatusOfRoomDal StatusOfRoomDal { get; }

        public IUseOfExtraServiceDal UseOfExtraServiceDal { get; }

        public IWebReservationDal WebReservationDal { get; }

        public IWorkScheduleDal WorkScheduleDal { get; }

        public void Dispose()
        {
            context.Dispose();
        }

        public int SaveChange()
        {
            return context.SaveChanges();
        }
    }
}
