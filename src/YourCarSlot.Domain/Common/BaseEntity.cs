using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourCarSlot.Domain.Common
{
    public class BaseEntity
    {
        public Guid Id { get; protected set; }
        public DateTime? CreatedAt { get; protected set; }
        public DateTime? DateModified { get; protected set; }
    }
}