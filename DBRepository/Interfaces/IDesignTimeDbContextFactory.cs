using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepository.Interfaces
{
    interface IDesignTimeDbContextFactory<out TContext> where TContext : DbContext
    {
        TContext CreateDbContext([NotNullAttribute] string[] args);
    }

    internal class NotNullAttribute : Attribute
    {
    }
}
