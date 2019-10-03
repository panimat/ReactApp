using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepository
{
    public interface IRepositoryContextFactory
    {
        RepositoryContext CreateDbContext(string connectionString);
    }
}
