﻿using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryModelDal : InMemoryEntityRepositoryBase<Model, int>, IModelDal
{
    protected override int generateId()
    {
        //throw new NotImplementedException();
        int nextId = _entities.Count == 0 ? 1 : _entities.Max(e => e.Id) + 1;
        return nextId;
    }
}
