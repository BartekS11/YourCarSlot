using YourCarSlot.Domain.Exceptions;

namespace YourCarSlot.Domain.ValueObjects
{
    public record Car
    {
        public string MakeOfCar { get; }  = string.Empty;
        public string PlateNumber { get; }  = string.Empty;
        public Localization CarLocalization { get; }
        public bool IsParked { get; }
        
        public Car(string makeofcar, string platenumber, 
                   Localization carlocalization, bool isparked)
        {
            if(string.IsNullOrWhiteSpace(makeofcar))
            {
                throw new EmptyMakeOfCarExceptions();
            }

            if(string.IsNullOrWhiteSpace(platenumber))
            {
                throw new EmptyPlateNumberException();
            }
            
            MakeOfCar = makeofcar;
            PlateNumber = platenumber;
            CarLocalization = carlocalization;
            IsParked = isparked;   
        }
    }
}