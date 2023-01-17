using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourCarSlot.Domain.Exceptions;
using YourCarSlot.Domain.ValueObjects;

namespace YourCarSlot.Domain.Entities
{
    public class ParkingList
    {
        public Guid Id { get; private set; }
        private ParkingListName _name;
        private Localization _localization;

        private readonly LinkedList<Car> _cars = new();



        internal ParkingList(Guid id, ParkingListName name, Localization localization, LinkedList<Car> cars)
        {
            Id = id;
            _name = name;
            _localization = localization;            
        }

        public void AddCar(Car car)
        {
            var alreadyExist = _cars.Any(i=> i.PlateNumber == car.PlateNumber);

            if(alreadyExist)
            {
                throw new CarAlreadyExistException(_name, car.PlateNumber, car.CarLocalization.ToString());
            }

            _cars.AddLast(car);
        }
    }
}