﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract;
public interface ITransmissionDal : IEntityRepository<Transmission, int>
{
    /*Dal:Data Access Layer;veritabanı işlemlerini gerçekleştiren katmanı temsil eder*/
}