﻿using Business.Requests.IndividualCustomer;

namespace Business.Abstract;

public interface IIndividualCustomerService
{
    GetIndividualCustomerListResponse GetList(GetIndividualCustomerListRequest request);
    GetIndividualCustomerByIdResponse GetById(GetIndividualCustomerByIdRequest request);
    AddIndividualCustomerResponse Add(AddIndividualCustomerRequest request);
    UpdateIndividualCustomerResponse Update(UpdateIndividualCustomerRequest request);
    DeleteIndividualCustomerResponse Delete(DeleteIndividualCustomerRequest request);
}
