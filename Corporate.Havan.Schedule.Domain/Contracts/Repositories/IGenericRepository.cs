using Corporate.Havan.Schedule.Domain.Base;
using System;

namespace Corporate.Havan.Schedule.Domain.Contracts.Repositories
{
    public interface IGenericRepository<T> : IDisposable where T : Entity
    {
       
    }
}
