using Corporate.Havan.Schedule.Domain.Base;
using Corporate.Havan.Schedule.Domain.Contracts.Repositories;
using Corporate.Havan.Schedule.Infra.Contexts;
using System;

namespace Corporate.Havan.Schedule.Infra.Repositories.Base
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        protected readonly HavanDbContext _context;

        public GenericRepository(HavanDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}

