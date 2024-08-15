using YourCarSlot.Shared.Abstractions.Exceptions;

namespace YourCarSlot.Domain.Exceptions
{
    public class CarAlreadyExistException : YourCarSlotException
    {
        public CarAlreadyExistException(string listName, string foundPlateNumber, string localization)
        : base($"Car with plate numbers: {foundPlateNumber} already exist in list: {listName} in location: {localization}")
        {

        }
    }
}