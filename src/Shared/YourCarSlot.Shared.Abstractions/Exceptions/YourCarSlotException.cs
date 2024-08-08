namespace YourCarSlot.Shared.Abstractions.Exceptions
{
    public abstract class YourCarSlotException : Exception
    {
        protected YourCarSlotException(string message) : base(message)
        {
            
        }   
    }
}