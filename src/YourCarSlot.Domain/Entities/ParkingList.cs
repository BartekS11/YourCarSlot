using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourCarSlot.Domain.Common;
using YourCarSlot.Domain.Exceptions;
using YourCarSlot.Domain.ValueObjects;

namespace YourCarSlot.Domain.Entities
{
    public class ParkingList : BaseEntity
    {
        private ParkingListName _name;
        private Localization _localization;
        private readonly LinkedList<Car> _cars = new();
        private static ParkingSlots _parkingSlots = new(10);
        
        public ParkingList(Guid id, ParkingListName name, Localization localization)
        {
            Id = id;
            _name = name;
            _localization = localization;
        }

        public void AddCar(Car car, int slot)
        {
            var alreadyExist = _cars.Any(i=> i.PlateNumber == car.PlateNumber);

            if(alreadyExist)
            {
                throw new CarAlreadyExistException(_name, car.PlateNumber, car.CarLocalization.ToString());
            }
            _parkingSlots.AddCarToParkingSlot(car, slot);
            _cars.AddLast(car);
        }
    }
}