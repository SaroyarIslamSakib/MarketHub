using System;
using System.Collections.Generic;
using System.Text;

namespace MarketHub.Domain
{
    public interface IUnitOfWork
    {
        void Save();
        Task SaveAsync();
    }
}
