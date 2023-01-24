using YourCarSlot.Domain.Exceptions;

namespace YourCarSlot.Domain.ValueObjects
{
    public class ParkingSlots
    {
        private int _spaceLimit = 100;
        private readonly List<KeyValuePair<string, int>> _parkingSlot = new();

        public ParkingSlots(int spaceLimit)
        {
            if(spaceLimit > _spaceLimit)
            {
                throw new FullParkingSpaceLimitException();
            }
            _spaceLimit = spaceLimit;
        }

        public void AddCarToParkingSlot(Car car, int slot)
        {
            var kvp = new KeyValuePair<string, int>(car.PlateNumber, slot); 

            if(_parkingSlot.Contains(kvp))
            {
                throw new FullParkingSpaceLimitException();
            }
            _parkingSlot.Add(kvp);
        }
    }
}