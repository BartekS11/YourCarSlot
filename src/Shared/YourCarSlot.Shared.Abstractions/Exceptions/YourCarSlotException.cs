namespace YourCarSlot.Shared.Abstractions.Exceptions
{
    //TODO: Create some new exception handling, maybe ErrOr?
    public abstract class YourCarSlotException : Exception
    {
        protected YourCarSlotException(string message) : base(message)
        {
            
        }   
    }
}