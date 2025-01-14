﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;

public class EfCustomerDal : EfEntityRepositoryBase<Customer, int, RentACarContext>, ICustomerDal
{
    public EfCustomerDal(RentACarContext context) : base(context)
    {
    }
}