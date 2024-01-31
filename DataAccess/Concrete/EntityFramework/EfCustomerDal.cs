﻿using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework;

public class EfCustomerDal : ICustomerDal
{
    private readonly RentACarContext _context;

    public EfCustomerDal(RentACarContext context)
    {
        _context = context;
    }

    public Customer Add(Customer entity)
    {
        entity.CreatedAt = DateTime.UtcNow;
        _context.Customers.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public Customer Delete(Customer entity, bool isSoftDelete = true)
    {
        entity.DeletedAt = DateTime.Now;
        if (isSoftDelete)
            _context.Customers.Remove(entity);

        _context.SaveChanges();
        return entity;
    }

    public Customer? Get(Func<Customer, bool> predicate)
    {
        Customer? customer = _context.Customers.FirstOrDefault(predicate);
        return customer;
    }

    public IList<Customer> GetList(Func<Customer, bool>? predicate = null)
    {
        Queryable<Customer> query = _context.Set<Customer>();
        if (predicate != null)
            query = query.Where(predicate).AsQueryable();

        return query.ToList();
    }

    public Customer Update(Customer entity)
    {
        entity.UpdateAt = DateTime.UtcNow;
        _context.Customers.Update(entity);
        _context.SaveChanges();
        return entity;
    }
}
