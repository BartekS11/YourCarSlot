namespace YourCarSlot.Domain.Common
{
    public class BaseEntity
    {
        public virtual Guid Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DateModified { get; set; }
    }
}