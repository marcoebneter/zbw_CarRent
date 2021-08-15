﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Common.Interfaces
{
    public interface IRepository<T, in TI>
    {
        List<T> GetAll();
        List<T> FindById(TI id);
        void Insert(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Remove(Guid id);
    }
}
