﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepository
{
    public class BaseRepository
    {
        protected string ConnectionString { get; }
        protected IRepositoryContextFactory ContextFactory { get; }
        public BaseRepository(string connectionString, IRepositoryContextFactory contextFactory)
        {
            ConnectionString = connectionString;
            ContextFactory = contextFactory;
        }
    }
}
