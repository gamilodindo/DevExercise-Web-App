﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace APOWeb.Core.Pattern
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
    }
}
