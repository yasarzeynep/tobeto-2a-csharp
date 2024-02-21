using Business.Requests.Brand;
using Business.Responses.Brand;

namespace Business.Abstract;

public interface IBrandService
{
    public AddBrandResponse Add(AddBrandRequest request);
    public GetBrandListResponse GetList(GetBrandListRequest request);
    public GetBrandByIdResponse GetById(GetBrandByIdRequest request);

    public UpdateBrandResponse Update(UpdateBrandRequest request);
    public DeleteBrandResponse Delete(DeleteBrandRequest request);
}
