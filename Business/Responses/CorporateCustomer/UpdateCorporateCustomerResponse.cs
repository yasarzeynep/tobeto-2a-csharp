namespace Business
{
    public class UpdateCorporateCustomerResponse
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public int UserId { get; set; }
        public DateTime UpdateAt { get; set; }

        public UpdateCorporateCustomerResponse(string companyName, string taxNo, int userId, DateTime updateAt)
        {
            CompanyName = companyName;
            TaxNo = taxNo;
            UserId = userId;
            UpdateAt = updateAt;
        }
    }
}