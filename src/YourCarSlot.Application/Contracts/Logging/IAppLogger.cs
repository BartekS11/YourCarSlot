using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourCarSlot.Application.Contracts.Logging
{
    public interface IAppLogger<T>
    {
        void LogInformation(string message, params object[] args);

        void LogWarning(string message, params object[] args);
    }
}