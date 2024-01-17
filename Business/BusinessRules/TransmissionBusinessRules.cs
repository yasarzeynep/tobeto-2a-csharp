using DataAccess.Abstract;
using System.Linq;

namespace Business.BusinessRules;

public class TransmissionBusinessRules
{
    private readonly ITransmissionDal _transmissionDal;

    public TransmissionBusinessRules(ITransmissionDal transmissionDal)
    {
        _transmissionDal = transmissionDal;
    }

    public bool CheckIfTransmissionNameExistsForAdd(string transmissionName)
    {
        var existingTransmission = _transmissionDal.GetList().FirstOrDefault(t => t.Name == transmissionName);
        return existingTransmission == null;
    }

    public bool CheckIfTransmissionNameExistsForUpdate(int transmissionId, string transmissionName)
    {
        var existingTransmission = _transmissionDal.GetList().FirstOrDefault(t => t.Id != transmissionId && t.Name == transmissionName);
        return existingTransmission == null;
    }

    public bool CheckIfTransmissionExistsForDelete(int transmissionId)
    {
        var existingTransmission = _transmissionDal.GetById(transmissionId);
        return existingTransmission != null;
    }
}
