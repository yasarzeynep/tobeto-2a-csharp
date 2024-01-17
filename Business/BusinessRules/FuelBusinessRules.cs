using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules;

public class FuelBusinessRules
{
    private readonly IFuelDal _fuelDal;

    public FuelBusinessRules(IFuelDal fuelDal)
    {
        _fuelDal = fuelDal;
    }
    //Add
    public void CheckIfFuelExistsForAdd(string fuelName)
    {
        var existingFuel = _fuelDal.GetList().FirstOrDefault(f => f.Name == fuelName);

        if (existingFuel != null)
        {
            throw new Exception("Fuel already exists.");
        }
    }

    //Update
    public void CheckIfFuelExistsForUpdate(int fuelId, string fuelName)
    {
        var existingFuel = _fuelDal.GetList().FirstOrDefault(f => f.Id != fuelId && f.Name == fuelName);

        if (existingFuel != null) //  varsa güncelleme yapma
        {
            throw new Exception("Fuel already exists.");
        }
    }

    //Delete
    public void CheckIfFuelExistsForDelete(int fuelId)
    {
        var existingFuel = _fuelDal.GetById(fuelId);

        if (existingFuel == null) // varsa silme yapma
        {
            throw new Exception("Fuel not found for delete.");
        }
    }
    //GetById 
    public void CheckIfIdIsValidForGetById(int fuelId)
    {
        if (fuelId <= 0)
        {
            throw new Exception("Invalid Id for GetById operation.");
        }
    }

    public void CheckIfFuelExistsForGetById(int fuelId)
    {
        var existingFuel = _fuelDal.GetById(fuelId);

        
        if (existingFuel == null)
        {
            throw new Exception("Fuel does not exist for Get By Id operation.");
        }
    }

    //GetList
    public void CheckIfFuelExistsForGetList()
    {
        var fuels = _fuelDal.GetList();

        if (fuels == null || !fuels.Any())
        {
            throw new Exception("No fuels found.");
        }
    }


}
