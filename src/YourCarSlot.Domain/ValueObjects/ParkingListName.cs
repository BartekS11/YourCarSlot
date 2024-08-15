using YourCarSlot.Domain.Exceptions;

namespace YourCarSlot.Domain.ValueObjects
{
    public record ParkingListName
    {
        public string Name { get; } = string.Empty;
        public ParkingListName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new EmptyParkingListException();
            }
            Name = name;
        }

        public static implicit operator string(ParkingListName name)
            => name.Name;

        public static implicit operator ParkingListName(string name)
            => new(name);
    }
}