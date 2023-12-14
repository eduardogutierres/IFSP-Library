﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.domain.Base
{
    public interface IBaseRepository<TEntity> where TEntity : IBaseEntity
    {
        void ClearChangeTracker();
        void AttachObject(object obj);
        void Insert(TEntity obj);

        void Update(TEntity obj);

        void Delete(object id);

        IList<TEntity> Select(IList<string>? includes = null);

        TEntity Select(object id, IList<string>? includes = null);
    }
}
