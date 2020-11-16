﻿using SampleProject.Core.Entities;
using System.Linq;

namespace SampleProject.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
